using System;
using System.Data;
using System.Data.SQLite;

namespace Services
{
    public class SQLiteProvider
    {
        private string connectionString;
        private SQLiteConnection connection;
        private SQLiteCommand command;

        public SQLiteProvider()
        {
            connectionString = @"Data Source=.\DSDbLite.db;Version=3;New=True;";
        }

        public DataTable ExecuteQuery(string query, string[] names = null, object[] values = null)
        {
            DataTable dt = new DataTable();
            using (connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                command = new SQLiteCommand(query, connection);
                if (values != null)
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        command.Parameters.AddWithValue(names[i], values[i] ?? DBNull.Value);
                    }
                }
                SQLiteDataAdapter adt = new SQLiteDataAdapter(command);
                adt.Fill(dt);
                connection.Close();
            }
            return dt;
        }

        public bool ExecuteNonQuery(string query, string[] names = null, object[] values = null)
        {
            bool result = false;
            using (connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    command = new SQLiteCommand(query, connection);
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
    }
}