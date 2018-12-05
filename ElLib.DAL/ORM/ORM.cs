using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElLib.DAL.ORM
{
    class ORM<T>
        where T : class
    {
        List<string> tables;
        readonly string connectionString;

        public ORM()
        {
            tables = new List<string>();
        }

        public ORM(string connectionString)
            :base()
        {
            this.connectionString = connectionString;
        }

        public void AddTableName(string table)
        {
            tables.Add(table);
        }
    }
}
