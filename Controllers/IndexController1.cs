using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_ElianMartinez.Models;

namespace Test_ElianMartinez.Controllers
{
    public class IndexController1 : Controller
    {
        //Builder _dbContext
        private readonly TESTContext _dbContext;

        public IndexController1(TESTContext Dbcontext)
        {
            _dbContext = Dbcontext;
        }
        //View People
        public IActionResult Create()
        {
            return View();
        }
        //Add People
        [HttpPost]
        public IActionResult Create(Person person)
        {
            try
            {
                _dbContext.People.Add(person);
                _dbContext.SaveChanges();
                return RedirectToAction("Index", "Home", _dbContext.People.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
            
        }

    }
}
