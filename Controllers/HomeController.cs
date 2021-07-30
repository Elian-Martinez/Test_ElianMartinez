using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Test_ElianMartinez.Models;


namespace Test_ElianMartinez.Controllers
{
    public class HomeController : Controller
    {
        //Var readonly TESTContext
        private readonly TESTContext _dbContext;

        //Builder _dbContext
        public HomeController(TESTContext Dbcontext)
        {
            _dbContext = Dbcontext;
        }

        //View Pleople
        public IActionResult Index()
        {
            var People = _dbContext.People.ToList();
            return View(People);
        }

        //Route Parameter People
        [Route("Home/Index/{id:int}")]
        public IActionResult Index(int id)
        {
            try
            {
                var person = _dbContext.People.Find(id);
                _dbContext.People.Remove(person);
                _dbContext.SaveChanges();

                
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.InnerException.Message;
            }

            return View(_dbContext.People.ToList());
        }


    }
}
