using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAccessLayer
{

    public class CrParameter
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public int Size { get; set; }
        public CrType  Type { get; set; }
    }

    public enum CrType
    {
        INT,
        DATE,
        STR
    }
}
