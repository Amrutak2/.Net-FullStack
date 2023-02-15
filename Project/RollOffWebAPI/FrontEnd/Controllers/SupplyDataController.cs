using FrontEnd.Models;
using FrontEnd.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace FrontEnd.Controllers
{
    public class SupplyDataController : Controller
    {
        //string Baseurl = "http://localhost:25962/api/Employee";
        public ActionResult Index()
        {
            IEnumerable<SupplyData> employee = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:25962/api/Employee");
                //HTTP GET
                var responseTask = client.GetAsync("employee");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<SupplyData>>();
                    readTask.Wait();

                    employee = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    employee= Enumerable.Empty<SupplyData>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(employee);
        }
        }
    }

