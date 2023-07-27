using DataAccess.GuardarRegistro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.GuardarRegistro
{
    public class registrosProductosDominio
    {
        private guardarProductos guardarProductos;
         
        guardarProductos gP = new guardarProductos();

        public bool InsertarProducto(string descripcion, decimal precio, int cantidad, string proveedor)
        {
            return gP.InsertarProducto(descripcion, precio, cantidad, proveedor);
        }

        public bool ActualizarProducto(int id, string descripcion, decimal precio, int cantidad, string proveedor)
        {
            return gP.ActualizarProducto(id, descripcion, precio, cantidad, proveedor);
        }

        public bool EliminarProducto(int id)
        {
            return gP.EliminarProducto(id);
        }
    }

}

