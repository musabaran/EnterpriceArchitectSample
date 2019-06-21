using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace EntitySchemaLibrary
{
    public class EntitySchemaList
    {
        private EntitySchemaList()
        {

        }

        static EntitySchemaList _schemaList;
        static object _locker = new object();
        public static EntitySchemaList Instance
        {
            get
            {
                if (_schemaList != null)
                    return _schemaList;
                lock (_locker)
                {
                    if (_schemaList == null)
                        _schemaList = new EntitySchemaList();
                    return _schemaList;
                }
            }
        }

        static Dictionary<string, EntitySchema> _schemas = new Dictionary<string, EntitySchema>();
        //duzenlenecek

        static object _l = new object();
        public EntitySchema GetSchema(string name)
        {
            //Interlocked.Increment()
            lock (_l)
            {
                if (!_schemas.ContainsKey(name))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(@"C:\4_11_EDP\Solution1\StaticEntitiesLibrary\" + name + ".xml");
                    EntitySchema schema = new EntitySchema(doc.SelectSingleNode("./Entity"));
                    _schemas.Add(name, schema);
                }
                return _schemas[name];
            }
        }
    }
}
