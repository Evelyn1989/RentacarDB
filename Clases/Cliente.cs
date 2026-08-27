using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarDB.Modelos
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string NumeroLicencia { get; set; }
        public DateTime FechaVencLicencia { get; set; }
        public int IdTipoIdentificacion { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaVencDocumento { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string Direccion { get; set; }

        public Cliente() { }

        public Cliente(int idCliente, string cedula, string nombre, string apellido,
                        string segundoApellido, DateTime fechaNacimiento, string telefono,
                        string correo, string numeroLicencia, DateTime fechaVencLicencia,
                        int idTipoIdentificacion, string sexo, DateTime fechaVencDocumento,
                        string pais, string provincia, string canton, string distrito, string direccion)
        {
            IdCliente = idCliente;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            SegundoApellido = segundoApellido;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Correo = correo;
            NumeroLicencia = numeroLicencia;
            FechaVencLicencia = fechaVencLicencia;
            IdTipoIdentificacion = idTipoIdentificacion;
            Sexo = sexo;
            FechaVencDocumento = fechaVencDocumento;
            Pais = pais;
            Provincia = provincia;
            Canton = canton;
            Distrito = distrito;
            Direccion = direccion;
        }

        public string NombreCompleto => $"{Nombre} {Apellido} {SegundoApellido}".Trim();
    }
}