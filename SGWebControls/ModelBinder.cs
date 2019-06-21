using CoreEntityLibrary;
using System;
using System.Web;
using System.Web.UI;

namespace SGWebControls
{
    internal class ModelBinder
    {
        internal static void Bind(Control modelPage)
        {
            foreach (Control control in modelPage.Controls)
            {
                if (control is IModel)
                {
                    BindEntity((IModel)control);
                }
                Bind(control);
            }
        }

        private static void BindEntity(IModel control)
        {
            EntityCollection coll = HttpContext.Current.Session["collection"] as EntityCollection;
            if (coll == null)
            {
                coll = new EntityCollection();
            }
            Entity e = null;
            if (!coll.ContainsKey(control.Model))
            {
                e = new Entity(control.Model);
                coll.Add(control.Model, e);
            }
            else
            {
                e = coll[control.Model];
            }

            e.Set(control.Property, control.Value);
            HttpContext.Current.Session["collection"] = coll;
        }
    }
    
}