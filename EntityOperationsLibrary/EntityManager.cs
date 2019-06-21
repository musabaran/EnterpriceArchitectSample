using CoreEntityLibrary;
using DbAccessLayer;
using EntitySchemaLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOperationsLibrary
{
    public class EntityManager
    {

        public static void Delete(Entity e)
        {
            EntitySchema schema = EntitySchemaList.Instance.GetSchema(e.Name);
            if (!schema.SoftDelete)
            {

            }
            else
            {
                // update...
            }
        }
        public static void Insert(Entity e)
        {
            string insertSql = "insert into [{0}]({1}) values({2})";
            StringBuilder sbColumns = new StringBuilder();
            StringBuilder sbParameters = new StringBuilder();


            EntitySchema schema = EntitySchemaList.Instance.GetSchema(e.Name);

            using (DbManager db = new DbManager())
            {
                foreach (EntityColumnSchema columnSchema in schema.Columns)
                {
                    if (columnSchema.IsAutoInc)
                        continue;
                    sbColumns.Append(columnSchema.Name);
                    if (columnSchema.IsML)
                        //string lanCode =GetLanguagePostFix();
                        sbColumns.Append("_EN");
                   sbColumns.Append(",");

                    sbParameters.Append("~");
                    sbParameters.Append(columnSchema.Name);
                    sbParameters.Append(",");

                    CrParameter p = new CrParameter();
                    p.Name = columnSchema.Name;
                    p.Size = columnSchema.Size;
                    p.Type = columnSchema.Type;
                    p.Value = e.Get<object>(columnSchema.Name);

                    db.Parameters.Add(p);

                }
                insertSql = string.Format(insertSql, schema.Name, sbColumns.ToString().TrimEnd(','),
                    sbParameters.ToString().TrimEnd(','));
                db.ExecuteNonQuery(insertSql);
            }
        }
    }
}
