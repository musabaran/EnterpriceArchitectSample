using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace SGWebControls
{
    public class CrButton : Button
    {
        public string AssemblyName { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            Assembly asm = Assembly.Load(AssemblyName);
            Type controller = asm.GetType(Controller);
            MethodInfo mi = controller.GetMethod(Action);
            object controllerInstance = Activator.CreateInstance(controller);
            mi.Invoke(controllerInstance, null);
        }
    }
}
