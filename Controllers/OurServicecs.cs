using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Venkant.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Venkant.Controllers
{
    public class OurService : Controller
    {

      //  private IClientsRepository _clientsRepository;

        public OurService()
        {

            // this is how you create instances of depenceses 
         //   _clientsRepository = new MockClientRepository();
        }

        
        
        public ViewResult ourService()
        {
            return View();
        }
        
        public ViewResult Overheating()
        {
            return View();
        }
        public ViewResult DiskCleanupServices()
        {
            return View();
        }
        public ViewResult HardDriveIssues()
        {
            return View();
        }
        
        public ViewResult ITSupport()
        {
            return View();
        }
        
        public ViewResult Keyboard()
        {
            return View();
        }
        
        public ViewResult Viruses()
        {
            return View();
        }
        
    }
}
