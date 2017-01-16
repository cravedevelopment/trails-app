using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using trails.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace trails.Controllers
{
    [Route("api/[controller]")]
    public class RunnerController : Controller
    {
        // GET api/runner
        [HttpGet]
        public Runner[] Get()
        {
            var runners = new List<Runner>();
            runners.Add(new Runner() { Id = 1, First = "Shayne", Last = "Boyer", Age = 42, FavoriteBeer = "Guiness" });
            runners.Add(new Runner() { Id = 2, First = "Edgar", Last = "Ursua", Age = 30, FavoriteBeer = "Red Horse" });
            runners.Add(new Runner() { Id = 3, First = "Ryan", Last = "Ursua", Age = 42, FavoriteBeer = "Red Horse" });

            return runners.ToArray();
        }

        // GET api/runner/5
        [HttpGet("{id}")]
        public Runner Get(int id)
        {
            return Get().Where(r=>r.Id == id).FirstOrDefault();
        }
    }
}
