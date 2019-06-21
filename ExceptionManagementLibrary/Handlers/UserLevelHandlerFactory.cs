using System;

namespace ExceptionManagementLibrary
{
    internal class UserLevelHandlerFactory : ExceptionHandlerFactory
    {
        internal override PublisherList GetPublishers()
        {
            PublisherList list = new PublisherList();
            return list;
        }

        internal override ExceptionRule GetRule()
        {
            return new NoneRule();
        }
    }
}