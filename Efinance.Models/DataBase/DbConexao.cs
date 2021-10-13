using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Efinance.Models.DataBase
{
    public class DbConexao : IDisposable
    {
        public IDbConnection Connection { get; }
        public IDbTransaction Transaction { get; }
        public DbConexao(IConfiguration configuration)
        {
            Connection = new SqlConnection(configuration.GetConnectionString("Nimbusdb_Conection"));
            Connection.Open();
        }

        public void Dispose() => Connection?.Dispose();

    }
}
