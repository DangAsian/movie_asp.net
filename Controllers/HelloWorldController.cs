using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
          return "this is default";

        }

        public string Welcome()
        {
          Console.WriteLine("Hello");
          return "This is something else";
        }
    }
}
