using System;
using System.Data.SqlClient;

namespace SkyReg.Common
{
    public class DatabaseAccess
    {
        public string ServerName { get; set; }
        public string DataBaseName { get; set; } = "BoutiqueShopp";
    }

    public sealed class DatabaseConfig
    {

        private static SqlConnection conn = null;
        private static SqlConnection updaterConn = null;
        private static SqlConnectionStringBuilder connBuilder = null;
        public static DatabaseAccess _databaseAccess { get; set; }
        public static SqlTransaction Transaction { get; private set; }

        public DatabaseConfig(DatabaseAccess DatabaseAccess)
        {
            _databaseAccess = DatabaseAccess;
        }

        public static SqlConnection Conn
        {
            get
            {
                if (conn == null)
                    conn = new SqlConnection(ConnectionString);
                return conn;
            }
            set
            {
                conn = value;
            }
        }


        public static SqlConnection SynchronizedConnection
        {
            get
            {
                if (updaterConn == null)
                    updaterConn = new SqlConnection(ConnectionString);
                return updaterConn;
            }
        }

        public static string ConnectionString
        {
            get
            {
                if (connBuilder == null)
                {
                    connBuilder = new SqlConnectionStringBuilder();
                    connBuilder.InitialCatalog = _databaseAccess.DataBaseName;
                    connBuilder.DataSource = _databaseAccess.ServerName;
                    return connBuilder.ConnectionString;
                }
                else
                    return connBuilder.ConnectionString;
            }
        }


        public static void BeginTransaction(string transactionName)
        {
            if (SynchronizedConnection.State == System.Data.ConnectionState.Closed)
                SynchronizedConnection.Open();
            Transaction = SynchronizedConnection.BeginTransaction(transactionName);
        }

        public static void CommitTransaction(string transactionName)
        {
            Transaction.Commit();
            SynchronizedConnection.Close();
            Transaction = null;
        }

        public static void RollbackTransaction(string transactionName)
        {
            if (Transaction != null)
            {
                Transaction.Rollback(transactionName);
                if (SynchronizedConnection.State == System.Data.ConnectionState.Open)
                    SynchronizedConnection.Close();
                Transaction = null;
            }
        }



    }

    public sealed class DatabaseManager
    {
        public static bool CreateDataBase(string script, string connectionString)
        {
            bool result = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = connectionString;
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = script;
                    cmd.Connection = con;

                    if (con.State != System.Data.ConnectionState.Open)
                        con.Open();
                    result = (bool)cmd.ExecuteScalar();

                }
            }
            catch (SqlException sqlex)
            {
                if ((sqlex.Class == 20) && (sqlex.Number == 53))
                {
                    throw new Exception("Nieprawidłowe parametry połączenia !", sqlex);
                }
                else
                {
                    throw new Exception(sqlex.Message, sqlex);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message, ex);
            }

            return result;
        }

        public static void GenerateDatabase(string script, string connectionString)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connectionString;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = script;
                cmd.Connection = con;

                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

    }
}

