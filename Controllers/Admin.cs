using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Venkant.Models;
using Venkant.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Venkant.Controllers
{
    public class Admin : Controller
    {
        public ViewResult AdminPanel()
        {
            return View();
        }
    }
}