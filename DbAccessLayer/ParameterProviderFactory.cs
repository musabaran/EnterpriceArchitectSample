using System;
using System.Data.Common;

namespace DbAccessLayer
{
    internal class ParameterProviderFactory
    {
        internal static ParameterProvider GetProvider(DbProviderFactory factory)
        {
            if (factory is System.Data.SqlClient.SqlClientFactory)
                return new SqlParameterProvider();
            else
                return new OracleParameterProvider();
        }
    }
}