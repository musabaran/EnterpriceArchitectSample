using System;

namespace ExceptionManagementLibrary
{
    internal class SqlExceptionPublisher : ExceptionPublisher
    {
        internal override void Publish(Exception e)
        {
            Console.WriteLine("Sql e yazildi");
        }

    }
}