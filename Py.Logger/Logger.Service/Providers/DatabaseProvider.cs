using System;
using System.Configuration;
using System.Data.SqlClient;
using Logger.Service.Entities;

namespace Logger.Service.Providers
{
    public class DatabaseProvider: ILogProvider
    {
        readonly string LogConnectionStr;

        public DatabaseProvider()
        {
            LogConnectionStr = ConfigurationManager.ConnectionStrings["log"].ConnectionString;
        }

        public void WriteMessage(LogEntity messageEntity)
        {
            using (SqlConnection connection = new SqlConnection(LogConnectionStr))
            {
                connection.Open();
                string commandText = "INSERT INTO Log (message) VALUES (@messageLog)";
                SqlCommand cmd = new SqlCommand(commandText, connection);
                cmd.Parameters.AddWithValue("@messageLog", messageEntity.FormattedMessage);
                cmd.ExecuteNonQuery();
            }            
        }
    }
}
