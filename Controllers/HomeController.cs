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
    public class HomeController : Controller
    {
        //  private IClientsRepository _clientsRepository;


        private EmailAddress FromAndToEmailAddress;
        private IEmailService EmailService;

        /*
        public HomeController()
        {
  
            // this is how you create instances of depenceses 
            //   _clientsRepository = new MockClientRepository();
        }
        
        */
        public HomeController(EmailAddress _fromAddress,
            IEmailService _emailService)
        {
            FromAndToEmailAddress = _fromAddress;
            EmailService = _emailService;
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                EmailMessage msgToSend = new EmailMessage
                {
                    FromAddresses = new List<EmailAddress> {FromAndToEmailAddress},
                    ToAddresses = new List<EmailAddress> {FromAndToEmailAddress},
                    Content = $"Here is your message: Name: {model.Name}, " +
                              $"Email: {model.Email}, Message: {model.Problem}",
                    Subject = "Contact Form"
                };

                EmailService.Send(msgToSend);
                return RedirectToAction("Index");
            }
            else
            {
                return Index();
            }
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