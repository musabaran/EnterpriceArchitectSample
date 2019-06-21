using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAccessLayer
{
    internal class SqlParameterProvider : ParameterProvider
    {
        public override string Prefix
        {
            get
            {
                return "@";
            }
        }

        protected override DbParameter CreateParameter(CrParameter crp)
        {
            return new SqlParameter();
        }

        protected override void SetDT(DbParameter p)
        {
            ((SqlParameter)p).SqlDbType = System.Data.SqlDbType.DateTime;
        }

        protected override void SetINT(DbParameter p)
        {
            ((SqlParameter)p).SqlDbType = System.Data.SqlDbType.Int;
        }

        protected override void SetSTR(DbParameter p)
        {
            ((SqlParameter)p).SqlDbType = System.Data.SqlDbType.NVarChar;
        }
    }
}
