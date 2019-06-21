using System;

namespace ExceptionManagementLibrary
{
    internal class OnErrorRule : ExceptionRule
    {
        internal override void Run(Exception e, PublisherList list)
        {
            foreach (ExceptionPublisher publisher in list)
            {
                try
                {
                    publisher.Publish(e);
                    break;

                }
                catch
                {

                }
            }
        }
    }
}