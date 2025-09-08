using Npgsql;
using System;

namespace ClinicaApp
{
    public static class MedicoAuth
    {
        public static bool ValidarLogin(string usuario, string senha)
        {
            using (var conn = DbConnectionFactory.GetConnection())
            using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM Medicos WHERE Usuario=@usuario AND Senha=@senha", conn))
            {
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                var count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
