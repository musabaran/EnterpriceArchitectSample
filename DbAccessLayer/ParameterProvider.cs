using System;
using System.Data.Common;

namespace DbAccessLayer
{
    internal abstract class ParameterProvider
    {
        public abstract string Prefix { get;}
        protected abstract DbParameter CreateParameter(CrParameter crp);
        protected abstract void SetINT(DbParameter p);
        protected abstract void SetSTR(DbParameter p);
        protected abstract void SetDT(DbParameter p);

        public   DbParameter GetParameter(CrParameter crp)
        {
            DbParameter prm = CreateParameter(crp);
            switch (crp.Type)
            {
                case CrType.INT:
                    SetINT(prm);            
                    break;
                case CrType.DATE:
                    SetDT(prm);
                    break;
                case CrType.STR:
                    SetSTR(prm);
                    break;
            }
            return prm;
        }
    }
}