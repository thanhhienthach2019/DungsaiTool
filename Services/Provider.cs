using System;
using System.Data;
using System.Data.SqlClient;

namespace Services
{
    public class Provider
    {
        private string connectionString;
        private SqlConnection connection;
        private SqlCommand command;

        public Provider()
        {
            connectionString = "Data Source=192.1.1.20,12526;Initial Catalog=DungSaiTool;User ID=sa;Password=sa";
        }

        /// <summary>
        /// Query with no output params
        /// </summary>
        /// <param name="query"></param>
        /// <param name="names"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public DataTable ExecuteQuery(string query, string[] names = null, object[] values = null)
        {
            DataTable dt = new DataTable();
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                if (values != null)
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        command.Parameters.AddWithValue(names[i], values[i] ?? DBNull.Value);
                    }
                }
                SqlDataAdapter adt = new SqlDataAdapter(command);
                adt.Fill(dt);
                connection.Close();
            }
            return dt;
        }

        /// <summary>
        /// Query with no output params
        /// </summary>
        /// <param name="query"></param>
        /// <param name="names"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public bool ExecuteNonQuery(string query, string[] names = null, object[] values = null)
        {
            bool result = false;
            using (connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    if (values != null)
                    {
                        for (int i = 0; i < values.Length; i++)
                        {
                            command.Parameters.AddWithValue(names[i], values[i] ?? DBNull.Value);
                        }
                    }
                    result = command.ExecuteNonQuery() > 0;
                    connection.Close();
                }
                catch { }
            }
            return result;
        }

        /// <summary>
        /// Query with output params
        /// </summary>
        /// <param name="query"></param>
        /// <param name="names"></param>
        /// <param name="values"></param>
        /// <param name="namesOut"></param>
        /// <param name="valuesOut"></param>
        /// <returns></returns>
        public bool ExecuteNonQuery(string query, string[] names, object[] values, string[] namesOut, ref object[] valuesOut)
        {
            bool result = false;
            int len;
            using (connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    len = values.Length;
                    for (int i = 0; i < len; i++)
                    {
                        command.Parameters.AddWithValue(names[i], values[i] ?? DBNull.Value).Direction = ParameterDirection.Input;
                    }
                    len = valuesOut.Length;
                    for (int i = 0; i < len; i++)
                    {
                        command.Parameters.Add(namesOut[i], (SqlDbType)valuesOut[i]).Direction = ParameterDirection.Output;
                    }
                    result = command.ExecuteNonQuery() > 0;
                    for (int i = 0; i < len; i++)
                    {
                        valuesOut[i] = command.Parameters[namesOut[i]].Value ?? null;
                    }
                    connection.Close();
                }
                catch { }
            }
            return result;
        }
    }
}