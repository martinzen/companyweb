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
        
        
        private EmailAddress FromAndToEmailAddress;
        private IEmailService EmailService;

        
        public ContactUs(EmailAddress _fromAddress,
            IEmailService _emailService)
        {
            FromAndToEmailAddress = _fromAddress;
            EmailService = _emailService;
        }
        
        
        [HttpGet]
        public ViewResult Contact()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Contact(ContactFormModel model)
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
                return RedirectToAction("Contact");
            }
            else
            {
                return Contact();
            }
        }
    }
}
