using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment5.Models;
using Assignment5.Helper;
using Assignment4.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Assignment5.Controllers
{
    public class HomeController : Controller
    {
        //GET: Student
        public IActionResult Index()
        {
            IEnumerable<Product> products = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52363/api/");
                //HTTP GET
                var responseTask = client.GetAsync("product");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Product>>();
                    readTask.Wait();

                    products = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    products = Enumerable.Empty<Product>();

                    ModelState.AddModelError(string.Empty, "Server error.");
                }
                return View(products);
            }
        }

        public IActionResult Edit(int id)
        {
            Product product = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52363/api/product/");
                //HTTP GET
                var responseTask = client.GetAsync(new Uri(client.BaseAddress, id.ToString()));
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Product>();
                    readTask.Wait();

                    product = readTask.Result;
                }
               
                return View(product);
            }
        }

        //ProductAPI _api = new ProductAPI();
        //public async Task<IActionResult> Index()
        //{
        //    List<Product> products = new List<Product>();
        //    HttpClient client = _api.Initial();
        //    HttpResponseMessage res = await client.GetAsync("api/product");
        //    if (res.IsSuccessStatusCode)
        //    {
        //        var result = res.Content.ReadAsStringAsync().Result;
        //        products = JsonConvert.DeserializeObject<List<Product>>(result);
        //    }
        //    return View(products);
        //}

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52363/api/product");
                //HTTP POST
                var postTask = client.PostAsJsonAsync<Product>("product", product);
                postTask.Wait();

                var result = postTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty, "Server Error.");

            return View(product);
        }

      /*  public IActionResult Edit(long id)
        {
            Product product = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52363/api/prooduct");
                //HTTP GET
                var responseTask = client.GetAsync("product=" + id.ToString());
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Product>(); //ERROR OVER HERE
                    readTask.Wait();
                    product = readTask.Result;
                }
            }
            return View();
        }
        */

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri("http://localhost:52363/api/product/");

                //HTTP POST
                // var putTask = client.PutAsJsonAsync<Product>(new Uri(client.BaseAddress, product.Id.ToString()), product);
                var putTask = client.PutAsJsonAsync<Product>(product.Id.ToString(), product);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52363/api/");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("product/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }

        
        public IActionResult Delete(Product product)
        {
            //Product product = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:52363/api/product/");
                //HTTP GET
                var responseTask = client.GetAsync(new Uri(client.BaseAddress, product.Id.ToString()));
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Product>();
                    readTask.Wait();

                    product = readTask.Result;
                }

                return View(product);
            }
        }













        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
