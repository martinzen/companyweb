using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Venkant.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Venkant.Controllers
{
    public class HomeController : Controller
    {

      //  private IClientsRepository _clientsRepository;

        public HomeController()
        {

            // this is how you create instances of depenceses 
         //   _clientsRepository = new MockClientRepository();
        }

        public ViewResult Index()
        {
            return View();
        }
        
        public ActionResult Home(int id)
        {
            return new RedirectResult(Url.Action("Index") + "#top");
        }
        
        public ActionResult About(int id)
        {
            return new RedirectResult(Url.Action("Index") + "#about");
        }
        
        public ActionResult Pricing(int id)
        {
            return new RedirectResult(Url.Action("Index") + "#pricing");
        }
        
        public ActionResult Blog(int id)
        {
            return new RedirectResult(Url.Action("Index") + "#blog");
        }
        
        public ActionResult Work(int id)
        {
            return new RedirectResult(Url.Action("Index") + "#work");
        }
        
        public ActionResult Contact(int id)
        {
            return new RedirectResult(Url.Action("Index") + "#contact");
        }
    }
}
