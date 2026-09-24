using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServicioProductos.DATA;
using WcfServicioProductos.Models;

namespace WcfServicioProductos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public List<Producto> ListarProductos()
        {
            // Retorna la lista completa desde la clase de datos en memoria
            return DataProducto.ObtenerProductos();
        }

        public Producto ObtenerProducto(int id)
        {
            // Busca y retorna el producto por su Id
            List<Producto> productos = DataProducto.ObtenerProductos();
            return productos.Find(p => p.Id == id);
        }
    }
}
