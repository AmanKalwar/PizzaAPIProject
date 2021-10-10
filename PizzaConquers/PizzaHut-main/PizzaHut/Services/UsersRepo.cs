using Microsoft.EntityFrameworkCore;
using PizzaHut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PizzaHut.Services
{
    public class UsersRepo
    {
        

     
        public UsersDTO Validate(UsersDTO users)
        {
            UsersDTO user = null;
            try
            {
                
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:26514/api/");
                    var postdata = client.PostAsJsonAsync<UsersDTO>("User/Login", users);
                    postdata.Wait();
                    if (postdata.Result.IsSuccessStatusCode)
                    {
                        var data = postdata.Result.Content.ReadFromJsonAsync<UsersDTO>();

                        data.Wait();

                        user = data.Result;
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
                 
                return user;
        }

        public UsersDTO Validate2(UsersDTO users)
        {
            UsersDTO user = null;
            try
            {
               
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:26514/api/");
                    var postdata = client.PostAsJsonAsync<UsersDTO>("User/Validate", users);
                    postdata.Wait();
                    if (postdata.Result.IsSuccessStatusCode)
                    {
                        var data = postdata.Result.Content.ReadFromJsonAsync<UsersDTO>();

                        data.Wait();

                        user = data.Result;
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return user;
        }
        public ICollection<UsersDTO> GetAll()
        {
            return null;
        }
       
        public UsersDTO Add(UsersDTO users)
        {
            UsersDTO user = null;

            try
            {
                
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:26514/api/");
                    var postdata = client.PostAsJsonAsync<UsersDTO>("User", users);
                    postdata.Wait();
                    if (postdata.Result.IsSuccessStatusCode)
                    {
                        var data = postdata.Result.Content.ReadFromJsonAsync<UsersDTO>();

                        data.Wait();

                        user = data.Result;
                    }
                }
                
            }
         
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return user;
        }
        public UsersDTO Get(int ID)
        {
            return null;
        }
    }
}
