using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RentacarDB.Clases
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public int IdTipoIdentificacion { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaVencimientoIdentificacion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}

