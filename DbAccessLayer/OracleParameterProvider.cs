using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAccessLayer
{
    class OracleParameterProvider : ParameterProvider
    {
        public override string Prefix
        {
            get
            {
                return ":";
            }
        }

        protected override DbParameter CreateParameter(CrParameter crp)
        {
            return new OracleParameter();
        }

        protected override void SetDT(DbParameter p)
        {
            ((OracleParameter)p).OracleType = OracleType.DateTime;
        }

        protected override void SetINT(DbParameter p)
        {
            ((OracleParameter)p).OracleType = OracleType.Int32;
        }

        protected override void SetSTR(DbParameter p)
        {
            ((OracleParameter)p).OracleType = OracleType.NVarChar;
        }
    }
}
