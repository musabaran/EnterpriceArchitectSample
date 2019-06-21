using System;

namespace ExceptionManagementLibrary
{
    internal class NoneRule : ExceptionRule
    {
        internal override void Run(Exception e, PublisherList list)
        {
            foreach(ExceptionPublisher publisher in list)
            {
                               
            }
        }
    }
}