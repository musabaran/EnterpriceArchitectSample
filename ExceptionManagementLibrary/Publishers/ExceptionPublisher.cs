using System;

namespace ExceptionManagementLibrary
{
    internal abstract class ExceptionPublisher
    {
        internal abstract void Publish(Exception e);
    }
}