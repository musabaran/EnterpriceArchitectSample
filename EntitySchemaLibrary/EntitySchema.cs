using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EntitySchemaLibrary
{
    public class EntitySchema
    {

        public EntitySchema(XmlNode entityNode)
        {
            Name = entityNode.Attributes["Name"].Value;
            SoftDelete = Convert.ToBoolean(entityNode.Attributes["SoftDelete"].Value);
            AuditLog = entityNode.Attributes["AuditLog"].Value;
            Columns = new EntityColumnsSchema(entityNode.SelectSingleNode("Columns"));
        }

        public string Name { get; set; }
        public bool SoftDelete { get; set; }
        public string AuditLog { get; set; }

        public EntityColumnsSchema Columns { get; set; }
    }


   
}
