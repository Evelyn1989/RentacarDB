using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarDB.Modelos
{
    public class ServicioAdicional
    {
        public int IdServicio { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public bool Estado { get; set; }

        public ServicioAdicional() { }

        public ServicioAdicional(int idServicio, string descripcion, decimal costo, bool estado)
        {
            IdServicio = idServicio;
            Descripcion = descripcion;
            Costo = costo;
            Estado = estado;
        }
    }
}