using System;

namespace RentacarDB.Modelos
{
    public class CategoriaVehiculo
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }

        public CategoriaVehiculo() { }

        public CategoriaVehiculo(int idCategoria, string nombreCategoria, string descripcion)
        {
            IdCategoria = idCategoria;
            NombreCategoria = nombreCategoria;
            Descripcion = descripcion;
        }
    }
}