using PizzaUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PizzaUsers.services
{
    public class ToppingsService
    {
        public ICollection<ToppingsDTO> GetAllToppings()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:28690/api/");
                    var getdata = client.GetFromJsonAsync<ICollection<ToppingsDTO>>("Toppings");
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

        public ToppingsDTO GetToppingById(int id)
        {
            try
            {

                using (var client = new HttpClient())
                {
                    //PizzaDTO pizza = new PizzaDTO() { ID = id };

                    //var value = new List<KeyValuePair<int, int>>();
                    //value.Add(new KeyValuePair<int, int>(id, id));
                    client.BaseAddress = new Uri("http://localhost:28690/api/");

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
