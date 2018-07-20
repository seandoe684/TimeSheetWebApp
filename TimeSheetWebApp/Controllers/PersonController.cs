using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeSheetWebApp.DAL;

namespace TimeSheetWebApp.Controllers
{
    public class PersonController : Controller
    {
        private IPersonRepository repository;

        public PersonController(IPersonRepository repo)
        {
            repository = repo;

        }



        public IActionResult Index()
        {
            return View();
        }

        public ViewResult List() => View(repository.People);
    }
}