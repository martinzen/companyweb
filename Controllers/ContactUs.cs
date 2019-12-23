using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Venkant.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Venkant.Controllers
{
    public class ContactUs : Controller
    {
        public ViewResult Contact()
        {
            return View();
        }
    }
}
