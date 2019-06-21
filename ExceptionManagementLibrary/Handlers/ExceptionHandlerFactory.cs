using System;

namespace ExceptionManagementLibrary
{

    internal abstract class ExceptionHandlerFactory
    {
        internal abstract PublisherList GetPublishers();
        internal abstract ExceptionRule GetRule();
    }
}