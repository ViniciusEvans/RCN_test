using Microsoft.AspNetCore.Mvc;
using test_2.Models;
using System.Collections.Generic;
namespace test_2.Controllers
{
    public class PersonsController : Controller
    {
        public IActionResult Index()
        {
            List<Person> list = new List<Person>();
            list.Add(new Person { Id = 1, Nome = "Vinicius", Idade = 19, Filhos = 0});
            list.Add(new Person { Id = 2, Nome = "Victor", Idade = 26, Filhos = 1});
            list.Add(new Person { Id = 3, Nome = "Adriana", Idade = 50, Filhos = 2});

            return View(list);
        }
    }
}
