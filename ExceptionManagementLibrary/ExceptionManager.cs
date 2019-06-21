using ExceptionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionManagementLibrary
{
    public class ExceptionManager
    {
        public static void Handle(Exception e)
        {
            ExceptionHandlerFactory factory = ExceptionHandlerFactories.GetFactory(e);
            PublisherList list = factory.GetPublishers();
            ExceptionRule rule = factory.GetRule();
            rule.Run(e, list);
        }
    }
}
