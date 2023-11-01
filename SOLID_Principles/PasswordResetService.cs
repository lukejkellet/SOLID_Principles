using SOLID_Principles.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    internal class PasswordResetService
    {
        private readonly IPasswordResetEmailSender emailSender;

        public PasswordResetService(IPasswordResetEmailSender emailSender)
        {
            this.emailSender = emailSender;
        }

        public void RequestPasswordReset(string username)
        {
            // Implement password reset logic
            // ...

            // Send a password reset email using the injected password reset email sender
            emailSender.SendPasswordResetEmail("user@example.com", "ResetLink");
        }
    }

}
