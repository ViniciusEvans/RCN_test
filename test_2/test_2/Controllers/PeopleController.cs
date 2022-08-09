using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using test_2.Data;
using test_2.Models;
using test_2.Repositories;

namespace test_2.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPeopleRepositorie _peopleRepositorie;
        public PeopleController(IPeopleRepositorie peopleRepositorie)
        {
            _peopleRepositorie = peopleRepositorie;
        }
        public IActionResult Index()
        {
            var dataView = _peopleRepositorie.AllPeoplePets();
           
            return View(dataView);
        }
        public IActionResult WhithoutPets()
        {
            var dataView = _peopleRepositorie.GetPeopleSons();

            return View(dataView);
        } 
        public IActionResult AllPets()
        {
            var dataView = _peopleRepositorie.GetPets();

            return View(dataView);
        }

    }
}
