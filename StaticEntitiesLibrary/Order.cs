using CoreEntityLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticEntitiesLibrary
{
    public class Order  :Entity
    {
        public Order(string name):base(name)
        {

        }
        public Order():base("Order")
        {
            
        }

        public int Id
        {
            get
            {
                return base.Get<int>("Id");
            }
            set
            {
                base.Set("Id", value);
            }
        }

        public int Price
        {
            get
            {
                return base.Get<int>("Price");
            }
            set
            {
                base.Set("Price", value);
            }
        }

        public string Code
        {
            get
            {
                return base.Get<string>("Code");
            }
            set
            {
                base.Set("Code", value);
            }
        }
    }
}
