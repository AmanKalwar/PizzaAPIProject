using PizzaUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PizzaUsers.services
{
    public class OrderServices
    {
        public OrderDTO Add(OrderDTO order)
        {
            OrderDTO orderDTO = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:46532/api/");
                var PostTask = client.PostAsJsonAsync<OrderDTO>("Orders", order);
                PostTask.Wait();
                var Result = PostTask.Result;
                if (Result.IsSuccessStatusCode)
                {
                    var data = Result.Content.ReadFromJsonAsync<OrderDTO>();
                    data.Wait();
                    orderDTO = data.Result;
                }
            }
            return orderDTO;
        }
    }
}
