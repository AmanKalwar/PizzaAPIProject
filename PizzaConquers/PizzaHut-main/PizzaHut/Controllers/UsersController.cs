using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.Logging;
using PizzaHut.Models;
using PizzaHut.Services;
using System;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PizzaHut.Controllers
{
    public class UsersController : Controller
    {
        public PizzaDTO pizza;
        private readonly UsersRepo _repo;
        private readonly ILogger<UsersController> _logger;
      
        private Regex regex;
        int Count = 0;
        static int Id;
        static double total = 0;
        static string UserId;
    
        public UsersController(ILogger<UsersController> logger, UsersRepo repo)
        {
            _repo = repo;
            _logger = logger;
           
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UsersDTO user)
        {
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrWhiteSpace(user.Email))
            {
                ViewBag.ErrorUser = "Enter Valid Email";
                return View();
            }
            else if (string.IsNullOrEmpty(user.Password) || string.IsNullOrWhiteSpace(user.Password))
            {
                ViewBag.ErrorPassword = "Invalid Password";
                return View();
            }
            else
            {
                UsersDTO users = _repo.Validate(user);
                if (users != null)
                {
                    ViewBag.Success1 = "Login Successfull";
                    TempData["Token"] = users.jwtToken;
                    TempData["UserName"] = users.Name;
                    TempData.Keep("UserName");
                    TempData["UserID"] = users.Email;
                    TempData.Keep("UserID");
                    TempData["Address"] = users.Address;
                    TempData.Keep("Address");
                    HttpContext.Session.SetString("UserID", user.Email);
                    TempData["CustID"] = users.UserId;
                    TempData.Keep("CustID");
                    TempData["Address"] = users.Address;
                    TempData.Keep("Address");
                    ViewBag.Email = users.Email;
                    return RedirectToAction("Index", "Pizza");
                }
                else
                {
                    ViewBag.Error = "No Such User Present";
                    return View();
                }
            }

        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Register user)
        {
            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrWhiteSpace(user.Email) || !ValidateEmailAddress(user.Email))
            {
                ViewBag.ErrorUser = "Enter Valid Email";
                return View();
            }
            else if (string.IsNullOrEmpty(user.Password) || string.IsNullOrWhiteSpace(user.Password) || !ValidatePassword(user.Password))
            {
                ViewBag.ErrorPassword = "Invalid Password";
                return View();
            }
            else if (string.IsNullOrEmpty(user.Password) || string.IsNullOrWhiteSpace(user.Password) || user.Password!=user.Re_Password)
            {
                ViewBag.ErrorRe_Password = "Password Miss-match";
                
                return View();
            }
            else if (string.IsNullOrEmpty(user.Name) || string.IsNullOrWhiteSpace(user.Name))
            {
                ViewBag.ErrorName = "Ïnvalid Name";
                return View();
            }
            else if (string.IsNullOrEmpty(user.Phone) || string.IsNullOrWhiteSpace(user.Phone) || !ValidatePhone(user.Phone))
            {
                ViewBag.ErrorPhone = "Invalid Phone Number";
            }
            else if (string.IsNullOrEmpty(user.Address) || string.IsNullOrWhiteSpace(user.Address))
            {
                ViewBag.ErrorAddress = "Invalid Address";
                return View();
            }
            else
            {
                UsersDTO users = new UsersDTO() { Email = user.Email, Password = user.Password, Address = user.Address, Phone = user.Phone,Name=user.Name};
                UsersDTO users1= _repo.Validate2(users);
                
                if (users1 != null)
                {
                    ViewBag.Error = "User Already Exists";
                    return View();
                }
                else
                {
                    UsersDTO userss = _repo.Add(users);
                    if (userss != null)
                    {
                        TempData["Token"] = userss.jwtToken;
                        TempData["UserID"] = userss.Email;
                        TempData.Keep("UserID");
                        TempData["UserName"] = userss.Name;
                        TempData.Keep("UserName");
                        TempData["Address"] = userss.Address;
                        TempData.Keep("Address");
                        TempData["CustID"] = userss.UserId;
                        TempData.Keep("CustID");
                        TempData["Address"] = userss.Address;
                        TempData.Keep("Address");
                        HttpContext.Session.SetString("UserID", user.Email);
                        ViewBag.Success = "Registeration Successfull";
                        return RedirectToAction("Index", "Pizza");
                    }

                    else
                    {
                        ViewBag.Error = "Some Error Occured";
                        return View();
                    }
                }


            }
            return View();
        }


        public bool ValidateEmailAddress(string email)
        {
            bool match = false;
            try
            {
                regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.CultureInvariant | RegexOptions.Singleline);
                return match = regex.IsMatch(email);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return match;
            }
        }
        public bool ValidatePassword(string plainText)
        {
            bool match = false;
            try
            {
                regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$");
                match = regex.IsMatch(plainText);
                return match;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return match;
            }

        }
        public static bool ValidatePhone(string phone)
        {
            bool match = false;
            try
            {
                return match = Regex.IsMatch(phone, "\\A[6-9][0-9]{9}\\z");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return match;
            }
        }

    }
}