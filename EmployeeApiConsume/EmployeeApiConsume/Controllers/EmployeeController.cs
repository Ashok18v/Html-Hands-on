using EmployeeApiConsume.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace EmployeeApiConsume.Controllers
{
    public class EmployeeController : Controller
    {

        Uri baseuri = new Uri("https://localhost:7162/api");
        HttpClient client = new HttpClient();
        List<Employee> Employeedata = new List<Employee>();
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmployeePut(Employee emp)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7162/api/");

                var putTask = client.PutAsJsonAsync<Employee>($"Employees/{emp.Id}",emp);

                putTask.Wait();

                var result = putTask.Result;

                if (result.IsSuccessStatusCode)

                {

                    return RedirectToAction("Index");

                }
                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
                return View(emp);
            }

        }
        public IActionResult Index()
        {
            client.BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + "/Employees").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            Employeedata = JsonConvert.DeserializeObject<List<Employee>>(data);
            return View(Employeedata);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmpolyePost(Employee emp)

        {

            using (var client = new HttpClient())

            {

                client.BaseAddress = new Uri("https://localhost:7162/api/Employees");

                //HTTP POST

                var postTask = client.PostAsJsonAsync<Employee>("Employees", emp);

                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)

                {

                    return RedirectToAction("Index");

                }

            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(Employeedata);

        }
        public ActionResult Edit(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }
            client.BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + "/Employees").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            Employeedata = JsonConvert.DeserializeObject<List<Employee>>(data);
            var emp = Employeedata.Where(e => e.Id == id).FirstOrDefault();
            return View(emp);
        }
    
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())

            {

                client.BaseAddress = new Uri("https://localhost:7162/api/Employees/");
                var delete = client.DeleteAsync($"{id}");
                delete.Wait();
                var results = delete.Result;
                if (results.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(Employeedata);

        }
        //public ActionResult Search()
        //{
        //    return View();
        //}
        public ActionResult Search(string search)
        {
            List<Employee> Employeedata = new List<Employee>();
            client.BaseAddress = baseuri;
            HttpResponseMessage response = client.GetAsync(baseuri + $"/Employees/{search}").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            Employeedata = JsonConvert.DeserializeObject<List<Employee>>(data);
            return View("Index",Employeedata);
        }


    }
}

