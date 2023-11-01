using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Interface
{
    internal interface IPasswordResetEmailSender
    {
        void SendPasswordResetEmail(string to, string resetLink);
    }

}
