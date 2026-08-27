using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarDB.Modelos
{
    public class Perfil
    {
        public int IdPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public Perfil() { }

        public Perfil(int idPerfil, string nombrePerfil, string descripcion, bool estado)
        {
            IdPerfil = idPerfil;
            NombrePerfil = nombrePerfil;
            Descripcion = descripcion;
            Estado = estado;
        }
    }
}