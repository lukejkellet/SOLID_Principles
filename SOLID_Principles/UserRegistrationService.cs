using SOLID_Principles.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    internal class UserRegistrationService
    {
        private readonly IUserRegistrationEmailSender emailSender;

        public UserRegistrationService(IUserRegistrationEmailSender emailSender)
        {
            this.emailSender = emailSender;
        }

        public void RegisterUser(string username, string password)
        {
            // Register the user in the database
            // ...

            // Send a user registration email using the injected email sender
            emailSender.SendUserRegistrationEmail("user@example.com", username);
        }
    }

}
