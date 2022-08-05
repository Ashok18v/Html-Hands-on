using AssignmentOnMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AssignmentOnMVC.Controllers
{
    public class Book_DetailsController : Controller
    {
        Uri baseuri = new Uri("https://localhost:7071/api/");
        HttpClient client = new HttpClient();
        List<Book_Details> books = new List<Book_Details>();
        List<Book_Details> book_details = new List<Book_Details>();
        public IActionResult Home()
        {
            client.BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + "Books").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            books = JsonConvert.DeserializeObject<List<Book_Details>>(data);
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
    
        public ActionResult AddBook(Book_Details bookdetails)

        {

            using (var client = new HttpClient()) { 
                client.BaseAddress = new Uri("https://localhost:7071/api/");

                //HTTP POST

                var postTask = client.PostAsJsonAsync<Book_Details>( "Books", bookdetails);

                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)

                {

                    return RedirectToAction("Home");
                }

            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(bookdetails);

        }
        public ActionResult Edit(int id)
        {
            client.BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + "Books").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            books = JsonConvert.DeserializeObject<List<Book_Details>>(data);
            var book = books.Where(e => e.Id == id).FirstOrDefault();
            return View(book);
        }
        [HttpPost]
        public ActionResult Save(Book_Details book_Details)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7071/api/");

                var putTask = client.PutAsJsonAsync<Book_Details>($"Books/{book_Details.Id}", book_Details);

                putTask.Wait();

                var result = putTask.Result;

                if (result.IsSuccessStatusCode)

                {

                    return RedirectToAction("Home");

                }
                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
                return View(book_Details);
            }
        }
            public ActionResult Delete(int id)
            {
                using (var client = new HttpClient())

                {
                    client.BaseAddress = new Uri("https://localhost:7071/api/Books/");
                    var delete = client.DeleteAsync($"{id}");
                    delete.Wait();
                    var results = delete.Result;
                    if (results.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Home");
                    }
                }
                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

                return View();
            }
        public ActionResult Details(int id)
        {
            client.BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + $"Books/{id}").Result;
            string data = response.Content.ReadAsStringAsync().Result;
          var  book = JsonConvert.DeserializeObject<Book_Details>(data);
            return View(book);

        }
        public ActionResult search( string search)
        {
            client.BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + "Books").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            books = JsonConvert.DeserializeObject<List<Book_Details>>(data);
            var search_book = books.Where(e => e.Name.Contains(search) || e.Zoner.Contains(search)).ToList();
            return View("Home",search_book);
          
        }
        public ActionResult AddCart(int id)
        {
            client.BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + "Books").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            book_details = JsonConvert.DeserializeObject<List<Book_Details>>(data);
            var book = book_details.Where(e => e.Id == id).FirstOrDefault();
            if(book== null)
            {
                return NoContent();
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7071/api/");

                //HTTP POST

                var postTask = client.PostAsJsonAsync<Book_Details>("Cart", book);

                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)

                {

                    return RedirectToAction("Home");
                }

            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View();

        }
        public ActionResult Cart()
        {
            client.BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + "Cart").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            book_details = JsonConvert.DeserializeObject<List<Book_Details>>(data);
            return View(book_details);
        }
        public ActionResult DeleteinCart(int id)
        {
            using (var client = new HttpClient())

            {
                client.BaseAddress = new Uri("https://localhost:7071/api/Cart/");
                var delete = client.DeleteAsync($"{id}");
                delete.Wait();
                var results = delete.Result;
                if (results.IsSuccessStatusCode)
                {
                    return RedirectToAction("Cart");
                }
            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View();
        }

    }

    }
    
