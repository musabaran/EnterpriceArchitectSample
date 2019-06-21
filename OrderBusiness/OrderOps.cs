using CoreEntityLibrary;
using EntityOperationsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OrderBusiness
{
    public class OrderOps
    {
        public void Save()
        {
            EntityCollection coll = HttpContext.Current.Session["collection"] as EntityCollection;
            Entity e =  coll["Order"];
            EntityManager.Insert(e);
        }
    }
}
