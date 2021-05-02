using Refactor.Framework;
using System;
using System.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;

namespace Refactor
{
    public class PersistanceUserSQL : IPersistanceUser, IDisposable
    {
        private SqlConnection connection;
        public PersistanceUserSQL()
        {
            connection = new SqlConnection("");
        }

        public void Dispose()
        {
            connection.Close();
        }

        public void Save(User user)
        {
            SqlCommand com = new SqlCommand($"insert into users values({user.UserName},{user.FirstName},{user.LastName},{user.Password})", connection);
            connection.Open();
            com.ExecuteNonQuery();
        }
    }
}
