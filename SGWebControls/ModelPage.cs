using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace SGWebControls
{
    public class ModelPage  :Page
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ModelBinder.Bind(this);
        }
    }
}
