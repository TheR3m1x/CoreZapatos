using DataAccess.DataView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DataView
{
    public class dataViewProductosDominio
    {
        //private dataViewProductos productoDataAccess;

        dataViewProductos productoDataAccess = new dataViewProductos();

        public DataTable ObtenerTodosProductos()
        {
            return productoDataAccess.ObtenerTodosProductos();
        }
        public DataTable ObtenerProductoPorId(int id)
        {
            return productoDataAccess.ObtenerProductoPorId(id);
        }

        public List<object> ObtenerProductosFiltrados(string searchText)
        {
            return productoDataAccess.ObtenerProductosFiltrados(searchText);
        }
    }
}
