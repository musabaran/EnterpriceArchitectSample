using System;

namespace ExceptionEntities
{
    public  class  CrException  : Exception
    {
        public int ErrorCode { get; set; }
        public int LanguageCode { get; set; }
        //
        //

    }
}