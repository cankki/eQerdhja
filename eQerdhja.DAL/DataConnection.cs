using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eQerdhja.DAL
{
    public class DataConnection
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["eQerdhjaConn"].ConnectionString;
            }
        }


        public static SqlConnection GetConnection()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();
                    return sqlConnection;
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
                throw;
            }
            finally
            {
                GetConnection().Dispose();
            }
        }

        public static SqlCommand GetSqlCommand(string query, SqlConnection sqlConnection, CommandType commandType)
        {
            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandType = commandType;
                    return sqlCommand;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                throw;
            }
        }

        public static void AddParameters(SqlCommand sqlCommand, string parameterName, object value)
        {
            try
            {
                SqlParameter sqlParameter = sqlCommand.CreateParameter();
                sqlParameter.ParameterName = parameterName;
                if (value != null)
                {
                    sqlParameter.Value = value ?? DBNull.Value;
                    sqlCommand.Parameters.Add(sqlParameter);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                throw;
            }
        }

        public static object ShowDataInGridView(string query)
        {
            using(SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query,ConnectionString))
            {
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                object data = dataSet.Tables[0];
                return data;
            }
        }

    }
}
