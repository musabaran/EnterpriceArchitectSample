using ExceptionEntities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAccessLayer
{
    public class DbManager :IDisposable
    {
        public DbManager()
        {
        }

        //lazy load..
        DbProviderFactory Factory
        {
            get
            {
                if (_providerFactory == null)
                {
                    string providerName = ConfigurationManager.AppSettings["providerName"];
                    _providerFactory = DbProviderFactories.GetFactory(providerName);
                }
                return _providerFactory;
    
            }
        }

        //Lazy<List<CrParameter>> cr = new Lazy<List<CrParameter>>(true);

        List<CrParameter> _parameters;
        public List<CrParameter> Parameters
        {
            get
            {
                if (_parameters == null)
                    _parameters = new List<CrParameter>();
                return _parameters;
            }
        }

        bool isDisposed = false;
        public void Dispose()
        {
            Dispose(true);
            //GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool isDisposing)
        {
           if(!isDisposed)
            {
                if (isDisposing)
                {
                    if (_connection != null)
                        _connection.Dispose();
                    if (_command != null)
                        _command.Dispose();
                }
                //kendime ait unmanaged memory yi temizliyorum....
                isDisposed = true;
            }
        }

        ~DbManager()
        {
           
            Console.WriteLine(  "naber ? ");
            Dispose(false);
        }


        DbConnection _connection;
        DbCommand _command;
        DbProviderFactory _providerFactory;


        public void ExecuteNonQuery(string v)
        {
            try
            {
                OpenConnection();
                PrepareCommand(v);
                _command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw new CoreLevelException();
            }
            finally
            {
                CloseConnection();
            }
        }

        public T ExecuteScalar<T>(string query)
        {
            T result = default(T);
            try
            {
                OpenConnection();
                PrepareCommand(query);
                result =(T)Convert.ChangeType( _command.ExecuteScalar(), typeof(T));
            }
            catch (Exception e)
            {
                throw new CoreLevelException();
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }

        private void PrepareCommand(string query)
        {
            _command = Factory.CreateCommand();
            _command.CommandText = query;

            CrParameterdBuilder.Build(_command, Parameters, Factory);
            _command.Connection = _connection;
        }

        private void CloseConnection()
        {
            if (_connection != null)
            {
                if (_connection.State != System.Data.ConnectionState.Closed)
                    _connection.Close();
            }
        }

       

        private void OpenConnection()
        {
            if (_connection == null)
            {
                _connection = Factory.CreateConnection();
                _connection.ConnectionString = ConfigurationManager.AppSettings["constr"];
            }
             if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }       
        }
    }

    
}
