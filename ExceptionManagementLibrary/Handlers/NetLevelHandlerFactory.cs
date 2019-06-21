using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionManagementLibrary
{
    internal class NetLevelHandlerFactory : ExceptionHandlerFactory
    {
        internal override PublisherList GetPublishers()
        {
            return new PublisherList() { new MailExceptionPublisher() };
        }

        internal override ExceptionRule GetRule()
        {
            //return new OnErrorRule();

            return new DotNetRule();
        }
    }
}
