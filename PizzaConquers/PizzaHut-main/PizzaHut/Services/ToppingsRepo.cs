using PizzaHut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PizzaHut.Services
{
    public class ToppingsRepo
    {
        public IEnumerable<ToppingsDTO> GetAll(string Token)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:26514/api/");
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token);
                    var getdata = client.GetFromJsonAsync<ICollection<ToppingsDTO>>("Toppings/GetToppings");
                    //Console.WriteLine("The number of COUNT"+getdata.Result.Count);


                    if (getdata != null)
                    {

                        return getdata.Result;

                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            return null;


        }
        public ToppingsDTO Get(int id, string Token)
        {
            try
            {

                using (var client = new HttpClient())
                {
                    //PizzaDTO pizza = new PizzaDTO() { ID = id };

                    //var value = new List<KeyValuePair<int, int>>();
                    //value.Add(new KeyValuePair<int, int>(id, id));
                    client.BaseAddress = new Uri("http://localhost:28690/api/");
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token);

                    var getdata = client.GetFromJsonAsync<ToppingsDTO>("Toppings/" + id);

                    getdata.Wait();
                    if (getdata != null)
                    {
                        return getdata.Result;
                    }
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
