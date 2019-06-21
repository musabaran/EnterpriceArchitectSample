using ExceptionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntityLibrary
{
    public class Entity
    {
        Dictionary<string, EntityColumn> _columns = new Dictionary<string, EntityColumn>();
        public string Name { get; set; }

        public Entity(string name)
        {
            Name = name;
        }


        public void Set(string name, object value)
        {
            if (!_columns.ContainsKey(name))
            {
                EntityColumn column = new EntityColumn();
                column.Name = name;
                column.Value = value;

                _columns.Add(name, column);
            }
            else
            {
                _columns[name].Value = value;
                _columns[name].IsDirty = true;
            }
        }
        public T Get<T>(string name)
        {
            if (_columns.ContainsKey(name))
                return (T)Convert.ChangeType(_columns[name].Value, typeof(T));
            throw new CoreLevelException();
        }
    }
}
