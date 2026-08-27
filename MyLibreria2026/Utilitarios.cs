using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MyLibreria2026
{
    public class Utilitarios
    {
        public static DataSet ejecutar(string comando)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MurrayLaptop\MSSQLSERVER2025;Initial Catalog=RentCarDB;Integrated Security=True");
            conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando, conn);
            adaptador.Fill(ds);
            conn.Close();
            return ds;
        }

        public static string codificar(string contrasena)
        {
            byte[] datos = Encoding.UTF8.GetBytes(contrasena);
            return Convert.ToBase64String(datos);
        }

        public static string decodificar(string contrasena)
        {
            byte[] datos = Convert.FromBase64String(contrasena);
            return Encoding.UTF8.GetString(datos, 0, datos.Length);
        }
    }
}