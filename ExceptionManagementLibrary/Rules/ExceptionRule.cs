using System;

namespace ExceptionManagementLibrary
{
    internal abstract class ExceptionRule
    {
        internal abstract void Run(Exception e, PublisherList list);
        
    }
}