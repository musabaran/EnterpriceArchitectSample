using System;
using System.Data;

namespace ExceptionManagementLibrary
{
    internal class CriticalLevelHandlerFactory : ExceptionHandlerFactory
    {
        internal override PublisherList GetPublishers()
        {
            PublisherList list = new PublisherList();
            list.Add(new EVExceptionPublisher());
            list.Add(new SqlExceptionPublisher());
            return list;

        }

        internal override ExceptionRule GetRule()
        {
            return new OnErrorRule();
        }
    }
}