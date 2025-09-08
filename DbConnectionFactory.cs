using Npgsql;
using System;

namespace ClinicaApp
{
    public static class DbConnectionFactory
    {
        // Altere os dados conforme seu ambiente PostgreSQL
        private const string ConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=clinica";

        public static NpgsqlConnection GetConnection()
        {
            var conn = new NpgsqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
