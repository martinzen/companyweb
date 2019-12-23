using System;
using System.Collections.Generic;
using System.Linq;
using MimeKit;

namespace Venkant.Models
{
    public class ContactFormModel
    {
        // model to gather the informaiton from the form 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Problem { get; set; }
    }
    
    public class ContactUsFormModel
    {
        // model to gather the informaiton from the form 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        
    }

    // model to gather the information for the email and the name 
    public class EmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    // Model for the message where  will be sent to and from who. 
    public class EmailMessage
    {
        public List<EmailAddress> ToAddresses { get; set; } = new List<EmailAddress>();
        public List<EmailAddress> FromAddresses { get; set; } = new List<EmailAddress>();
        public string Subject { get; set; }
        public string Content { get; set; }
    }

    public class EmailServerConfiguration
    {
        public EmailServerConfiguration(int _smtpPort = 587)
        {
            SmtpPort = _smtpPort;
        }

        public string SmtpServer { get; set; }
        public int SmtpPort { get; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
    }

    public interface IEmailService
    {
        void Send(EmailMessage message);
    }

    public class MailKitEmailService : IEmailService
    {
        private readonly EmailServerConfiguration _eConfig;

        public MailKitEmailService(EmailServerConfiguration config)
        {
            _eConfig = config;
        }

        public void Send(EmailMessage msg)
        {
            var message = new MimeMessage();
            message.To.AddRange(msg.ToAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));
            message.From.AddRange(msg.FromAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));

            message.Subject = msg.Subject;

            message.Body = new TextPart("plain")
            {
                Text = msg.Content
            };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect(_eConfig.SmtpServer, _eConfig.SmtpPort);

                client.AuthenticationMechanisms.Remove("XOAUTH2");

                client.Authenticate(_eConfig.SmtpUsername, _eConfig.SmtpPassword);

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}