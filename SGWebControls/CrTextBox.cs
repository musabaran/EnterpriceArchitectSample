using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace SGWebControls
{
    public class CrTextBox : TextBox, IModel
    {
        public string Model
        {
            get
            ;

            set
            ;
        }

        public string Property
        {
            get
            ;

            set
            ;
        }

        public object Value
        {
            get
            {
                return this.Text;
            }

            set
            {
                this.Text = value.ToString();
            }
        }
    }
}
