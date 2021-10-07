using PizzaUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PizzaUsers.services
{
    public class OrderDetailServices
    {
        public OrderDetailDTO Add(OrderDetailDTO order)
        {
            OrderDetailDTO orderDTO = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:44463/api/");
                var PostTask = client.PostAsJsonAsync<OrderDetailDTO>("OrderDetail", order);
                PostTask.Wait();
                var Result = PostTask.Result;
                if (Result.IsSuccessStatusCode)
                {
                    var data = Result.Content.ReadFromJsonAsync<OrderDetailDTO>();
                    data.Wait();
                    orderDTO = data.Result;
                }
            }
            return orderDTO;
        }
    }
}
