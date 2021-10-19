using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PizzaHut.Models;
using PizzaHut.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaHut.Controllers
{
    public class OrdersController : Controller
    {
        UsersDTO user = new UsersDTO();
        List<OrdersDTO> Orders = new List<OrdersDTO>();
        List<PizzaDTO> Pizza1 = new List<PizzaDTO>();

        private readonly ILogger<OrdersController> _logger;
        private readonly OrderDetailRepo _repoo;
        private readonly OrderRepo _repo;
        private readonly PizzaRepo _Prepo;
        public Dictionary<string, Cart> PizzaList;
        public Dictionary<string, List<ToppingsDTO>> ToppingsList;



        public OrdersController(ILogger<OrdersController> logger, OrderRepo repo, PizzaRepo Prepo, OrderDetailRepo repoo)
        {
            _repo = repo;
            _Prepo = Prepo;
            _logger = logger;
            _repoo = repoo;
        }
        public IActionResult Index()
        {
            PizzaList = JsonConvert.DeserializeObject<Dictionary<string, Cart>>(HttpContext.Session.GetString("Pizza"));

            int count = 0;

            double sum = 0;
            if (PizzaList.Count == 0)
            {
                TempData["Empty"] = "Please place the order";
                return View();
            }
           
            else
            {
                PlaceOrders();
                if (Orders.Count == 0)
                {
                    TempData["Added"] = null;
                    TempData["deleted"] = null;
                    TempData["Error"] = "Some Error try after sometime";
                    return RedirectToAction("Details", "Toppings");
                }
                ViewData["Orders"] = Orders;
                foreach (var item in Orders)
                {
                    Pizza1.Add(_Prepo.Get(item.PizzaID, TempData.Peek("Token").ToString()));
                    sum = sum + item.Price;
                    count += item.Qty;
                }
                ViewData["Users"] = user.Address;
                ViewData["count"] = count;
                ViewData["Pizza"] = Pizza1;
                ViewData["Sum"] = sum;
                TempData["Empty"] = null;
                return View();

            }

        }
        public void PlaceOrders()
        {
            OrdersDTO order;
            PizzaList = JsonConvert.DeserializeObject<Dictionary<string, Cart>>(HttpContext.Session.GetString("Pizza"));
            if (HttpContext.Session.GetString("Toppings") != null)
                ToppingsList = JsonConvert.DeserializeObject<Dictionary<string, List<ToppingsDTO>>>(HttpContext.Session.GetString("Toppings"));
            else
                ToppingsList = null;

            foreach (var item in PizzaList.Keys)
            {
                double subTotal = 0;

                if (ToppingsList != null && ToppingsList.ContainsKey(item))
                {
                    double sum = 0;
                    foreach (var items in ToppingsList[item])
                    {
                        sum += items.Price;
                    }
                    subTotal += (PizzaList[item].Pizza.Price + sum) * PizzaList[item].Qty;
                    order = new OrdersDTO() { Qty = PizzaList[item].Qty, PizzaID = PizzaList[item].Pizza.ID, Price = subTotal, date = DateTime.Now, CustomerID = Convert.ToInt32(TempData.Peek("CustID")), PizzaName = PizzaList[item].Pizza.Name, Address = TempData.Peek("Address").ToString() };

                    OrdersDTO orders = _repo.Add(order, TempData.Peek("Token").ToString());

                    if (orders != null)
                    {
                        Orders.Add(orders);
                        foreach (var items in ToppingsList[item])
                        {
                            OrderDetailsDTO details = new OrderDetailsDTO() { ToppingsID = items.ID, OrderID = orders.OrderID, ToppingsName = items.Name, Date = DateTime.Today };
                            if (_repoo.Add(details, TempData.Peek("Token").ToString()) != null)
                            {
                                _logger.LogInformation("Order Successfull");

                            }
                            else
                            {
                                _logger.LogInformation("Null Returned");
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    order = new OrdersDTO() { Qty = PizzaList[item].Qty, PizzaID = PizzaList[item].Pizza.ID, Price = (PizzaList[item].Pizza.Price) * PizzaList[item].Qty, date = DateTime.Now, CustomerID = Convert.ToInt32(TempData.Peek("CustID")), PizzaName = PizzaList[item].Pizza.Name, Address = TempData.Peek("Address").ToString() };
                    OrdersDTO orderss = _repo.Add(order, TempData.Peek("Token").ToString());
                    if (orderss != null)
                    {
                        Orders.Add(orderss);
                        _logger.LogInformation("Order placed Successfully");
                    }

                }
                }
                PizzaList.Clear();
                HttpContext.Session.SetString("Pizza", JsonConvert.SerializeObject(PizzaList));
                if (ToppingsList != null)
                {
                    ToppingsList.Clear();
                    HttpContext.Session.SetString("Toppings", JsonConvert.SerializeObject(ToppingsList));
                }


            }
        }
    }
