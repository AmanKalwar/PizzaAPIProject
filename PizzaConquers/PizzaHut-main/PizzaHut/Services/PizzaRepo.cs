using Newtonsoft.Json;
using PizzaHut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PizzaHut.Services
{
    public class PizzaRepo
    {
        public ICollection<PizzaDTO> GetAll(string Token)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:26514/api/");
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token);
                    var getdata = client.GetFromJsonAsync<ICollection<PizzaDTO>>("Pizza/GetPizza");
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

        public PizzaDTO Get(int id, string Token)
        {
            try { 
            using (var client = new HttpClient())
            {
               
                client.BaseAddress = new Uri("http://localhost:26514/api/");
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token);

                var getdata = client.GetFromJsonAsync<PizzaDTO>("Pizza/" + id);
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
