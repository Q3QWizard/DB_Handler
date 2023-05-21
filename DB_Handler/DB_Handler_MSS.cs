using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Handler
{
    public class DB_Handler_MSS
    {

        private string _ConnectionString { get; set; }

        public DB_Handler_MSS()
        {
            _ConnectionString = "Server=DESKTOP-JCUOVSU;Database=DB_Handler;User Id=sa;Password=dev@12345;";
        }
        public DataSet GetDataSet(string sqlQuery)
        {
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection connection = new SqlConnection(_ConnectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                    adapter.Fill(ds);
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return ds;
        }
        public DataSet GetDataSet(string sqlQuery, List<QueryParam> qParams)
        {
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection connection = new SqlConnection(_ConnectionString))
                {
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    if (qParams != null && qParams.Count > 0)
                    {
                        foreach (QueryParam obj in qParams)
                        {
                            command.Parameters.Add(obj.Param, obj.ParamSqlDBType);
                            command.Parameters[obj.Param].Value = obj.ParamValue;
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return ds;
        }
        public bool ExecuteNonQuery(string sqlQuery, List<QueryParam> qParams)
        {
            bool flag = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(_ConnectionString))
                {
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    if (qParams != null && qParams.Count > 0)
                    {
                        foreach (QueryParam obj in qParams)
                        {
                            command.Parameters.Add(obj.Param, obj.ParamSqlDBType);
                            command.Parameters[obj.Param].Value = obj.ParamValue;
                        }

                        connection.Open();
                        Int32 rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine("RowsAffected: {0}", rowsAffected);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            
            return flag;
        }

    }

    public class QueryParam
    {
        public string Param { get; set; }
        public dynamic ParamValue { get; set; }
        public SqlDbType ParamSqlDBType { get; set; }
    }
}
