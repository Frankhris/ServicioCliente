using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfServicioProductos.Models;

namespace WcfServicioProductos.DATA
{
    public class DataProducto
    {
        public static List<Producto> ObtenerProductos()
        {
            return new List<Producto>()
            {
                new Producto { Id = 1, Nombre = "Laptop Asus ", Precio = 2599.00m },
                new Producto { Id = 2, Nombre = "Mouse Gamer Inalámbrico", Precio = 145.50m },
                new Producto { Id = 3, Nombre = "Teclado Mecánico", Precio = 297.00m },
                new Producto { Id = 4, Nombre = "Monitor 32 pulgadas semicurvo", Precio = 650.00m },
                new Producto { Id = 5, Nombre = "Audífonos Gamer", Precio = 120.00m }
            };
        }
    }
}