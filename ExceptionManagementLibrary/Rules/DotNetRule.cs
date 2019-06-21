using System;

namespace ExceptionManagementLibrary
{
    internal class DotNetRule : ExceptionRule
    {
        internal override void Run(Exception e, PublisherList list)
        {
            Console.WriteLine("he he");
        }
    }
}