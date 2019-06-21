using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EntitySchemaLibrary
{
    public class EntityColumnsSchema : List<EntityColumnSchema>
    {

        public EntityColumnsSchema(XmlNode columnsNode)
        {
            foreach (XmlNode columnNode in columnsNode)
            {
                EntityColumnSchema column = new EntityColumnSchema(columnNode);
                this.Add(column);
            }
        }
    }
}
