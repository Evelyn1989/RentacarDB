using Microsoft.Data.SqlClient;

namespace RentacarDB.Conexion
{
    public class ConexionBD
    {
        private readonly string cadenaConexion =
            @"Server=DESKTOP-TU4JT6C\SQLEXPRESS;
              Database=RentCarDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}