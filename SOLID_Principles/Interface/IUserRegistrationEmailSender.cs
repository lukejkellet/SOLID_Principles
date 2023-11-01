using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Interface
{
    internal interface IUserRegistrationEmailSender
    {
        void SendUserRegistrationEmail(string to, string username);
    }

}
