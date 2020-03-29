using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CrudHub.WebClient.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudHub.WebClient.Controllers
{
    public class EmployeeController : Controller
    {
        // Get
        public IActionResult Index()
        {
            IEnumerable<mvcEmployeeModel> employeeList;

            HttpResponseMessage responce = GlobalWebApiClientVariables.WebApiClient.GetAsync("EmployeeAPI").Result;

            employeeList = responce.Content.ReadAsAsync<IEnumerable<mvcEmployeeModel>>().Result;

            return View(employeeList);
        }

        // Post
        public IActionResult CreateEmployee()
        {
            return View();
        }

        // Post
        [HttpPost]
        public IActionResult CreateEmployee(mvcEmployeeModel model)
        {
            if (!ModelState.IsValid)
            {
                throw new InvalidOperationException("Model is not correct");
            }
            HttpResponseMessage responce = GlobalWebApiClientVariables.WebApiClient.PostAsJsonAsync("EmployeeAPI", model).Result;

            return RedirectToAction("Index");
        }

        // Put
        public async Task<IActionResult> UpdateEmployee(int id)
        {
            //mvcEmployeeModel employeeToUpdate;
            HttpResponseMessage responce = GlobalWebApiClientVariables.WebApiClient.GetAsync($"EmployeeAPI/{id}").Result;

            var employeeToUpdate = await responce.Content.ReadAsAsync<mvcEmployeeModel>();

            return View(employeeToUpdate);
        }
        [HttpPost]
        public IActionResult UpdateEmployee(mvcEmployeeModel model)
        {
            if (!ModelState.IsValid)
            {
                throw new InvalidOperationException("Model is not correct");
            }
            HttpResponseMessage responce = GlobalWebApiClientVariables.WebApiClient.PutAsJsonAsync($"EmployeeAPI/{model.EmployeeId}", model).Result;

            return RedirectToAction("Index");
        }

        public IActionResult DeleteEmployee(int id)
        {
            HttpResponseMessage responce = GlobalWebApiClientVariables.WebApiClient.DeleteAsync($"EmployeeAPI/{id}").Result;

            return RedirectToAction("Index");
        }
    }
}