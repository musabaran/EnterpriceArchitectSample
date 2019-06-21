using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGWebControls
{
    public interface IModel
    {
        string Model { get; set; }
        string Property { get; set; }
        object Value { get; set; }
    }
}
