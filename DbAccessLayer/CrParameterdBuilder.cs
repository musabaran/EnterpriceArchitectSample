using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAccessLayer
{
    internal class CrParameterdBuilder
    {
        internal static void Build(DbCommand command, 
            List<CrParameter> parameters,
            DbProviderFactory factory)
        {

            ParameterProvider prmProvider = ParameterProviderFactory.GetProvider(factory);
            command.CommandText = command.CommandText.Replace("~",prmProvider.Prefix);

            foreach(CrParameter crp in parameters)
            {
                DbParameter p = prmProvider.GetParameter(crp);
                p.ParameterName = crp.Name;
                p.Size = crp.Size;
                p.Value = crp.Value;
                command.Parameters.Add(p);
            }
        }
    }
}
