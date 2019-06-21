using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionManagementLibrary
{
    class MailExceptionPublisher : ExceptionPublisher
    {
        internal override void Publish(Exception e)
        {
            throw new Exception();
            //Console.WriteLine("Mail atildi");
        }
        
    }
}
