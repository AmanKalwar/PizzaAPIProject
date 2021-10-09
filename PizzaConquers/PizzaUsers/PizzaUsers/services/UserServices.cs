using PizzaUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PizzaUsers.services
{
    public class UserServices
    {
        private readonly UserContext _context;
        private readonly ITokenServices _tokenServices;

        public UserServices(UserContext context, ITokenServices tokenService)
        {
            _context = context;
            _tokenServices = tokenService;

        }

        public UserDTO Validate(UserDTO userDTO)
        {
            UserDTO userDTO1 = null;
            try
            {
                if(_context.users.Where(e=>e.Email==userDTO.Email).Any())
                {
                    
                   var user = _context.users.FirstOrDefault(e => e.Email == userDTO.Email);
                    userDTO1 = new UserDTO() {Email=user.Email };
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return userDTO1;
        }

        public UserDTO Register(UserDTO userDTO)
        {
            try
            {
                using var hmac = new HMACSHA512();
                var user = new User()
                {
                    
                    Email=userDTO.Email,
                    Name=userDTO.Name,
                    Address=userDTO.Address,
                    Phone=userDTO.Phone,
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password)),
                    PasswordSalt = hmac.Key
                };
                _context.users.Add(user);
                _context.SaveChanges();
                userDTO.jwtToken = _tokenServices.CreateToken(userDTO);
                userDTO.Password = "";
                return userDTO;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }


        public UserDTO Login(UserDTO userDTO)
        {
            try
            {
                var myUser = _context.users.SingleOrDefault(u => u.Email == userDTO.Email);
                if (myUser != null)
                {
                    using var hmac = new HMACSHA512(myUser.PasswordSalt);
                    var userPassword = hmac.ComputeHash(Encoding.UTF8.GetBytes(userDTO.Password));

                    for (int i = 0; i < userPassword.Length; i++)
                    {
                        if (userPassword[i] != myUser.PasswordHash[i])
                            return null;
                    }
                    userDTO.jwtToken = _tokenServices.CreateToken(userDTO);
                    userDTO.Name = myUser.Name;
                    userDTO.UserId = myUser.UserId;
                    userDTO.Address = myUser.Address;
                    userDTO.Password = "";
                    return userDTO;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
