using System;

namespace ExceptionManagementLibrary
{
    internal class EVExceptionPublisher : ExceptionPublisher
    {
        internal override void Publish(Exception e)
        {
            Console.WriteLine("Ev ye yazildi");
        }
    }
}