using DbAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EntitySchemaLibrary
{

   

    public class EntityColumnSchema
    {

        public EntityColumnSchema(XmlNode columnNode)
        {
            Name = columnNode.Attributes["Name"].Value;
            IsPrimary = Convert.ToBoolean( columnNode.Attributes["IsPrimary"].Value);
            IsML = Convert.ToBoolean(columnNode.Attributes["ML"].Value);
            IsAutoInc = Convert.ToBoolean(columnNode.Attributes["AutoInc"].Value);
            IsNull = Convert.ToBoolean(columnNode.Attributes["IsNull"].Value);
            Type = (CrType)Enum.Parse(typeof(CrType), columnNode.Attributes["Type"].Value);
            Size = Convert.ToInt32(columnNode.Attributes["Size"].Value);
        }

        public string Name { get; set; }
        public CrType   Type { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsML { get; set; }
        public bool IsAutoInc { get; set; }
        public bool IsNull { get; set; }

        public int Size { get; set; }

    }
  


}
