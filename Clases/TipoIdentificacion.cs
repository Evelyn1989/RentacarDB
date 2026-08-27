using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarDB.Modelos
{
    public class TipoIdentificacion
    {
        public int IdTipoIdentificacion { get; set; }
        public string Descripcion { get; set; }

        public TipoIdentificacion() { }

        public TipoIdentificacion(int idTipoIdentificacion, string descripcion)
        {
            IdTipoIdentificacion = idTipoIdentificacion;
            Descripcion = descripcion;
        }
    }
}