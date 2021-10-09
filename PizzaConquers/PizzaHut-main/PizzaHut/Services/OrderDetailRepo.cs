using PizzaHut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PizzaHut.Services
{
    public class OrderDetailRepo
    {
        public OrderDetailsDTO Add(OrderDetailsDTO ordersdetail, string Token)
        {
            OrderDetailsDTO orders1 = null;

            try
            {

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:26514/api/");
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token);
                    var postdata = client.PostAsJsonAsync<OrderDetailsDTO>("OrderDetail", ordersdetail);
                    postdata.Wait();
                    if (postdata.Result.IsSuccessStatusCode)
                    {
                        var data = postdata.Result.Content.ReadFromJsonAsync<OrderDetailsDTO>();

                        data.Wait();

                        orders1 = data.Result;
                    }
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return orders1;
        }
    }
}
