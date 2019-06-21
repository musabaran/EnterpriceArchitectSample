using System;

namespace ExceptionManagementLibrary
{
//    [ExceptionType(Type = "CorelevelExcepition")]

    internal class CoreLevelHandlerFactory : ExceptionHandlerFactory
    {
        internal override PublisherList GetPublishers()
        {
            //config den 
            // db okudu

            PublisherList list = new PublisherList();
            list.Add(new SqlExceptionPublisher());
            list.Add(new MailExceptionPublisher());
            list.Add(new EVExceptionPublisher());
            return list;
        }

        internal override ExceptionRule GetRule()
        {
            return new AllRule();
        }

       
    }

   
}