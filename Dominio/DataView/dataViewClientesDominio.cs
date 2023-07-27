using DataAccess.DataView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DataView
{
    public class dataViewClientesDominio
    {
        private dataViewClientes clienteDataAccess;

        public dataViewClientesDominio()
        {
            clienteDataAccess = new dataViewClientes();
        }

        public DataTable ObtenerTodosClientes()
        {
            return clienteDataAccess.ObtenerTodosClientes();
        }

        public DataTable ObtenerClientePorId(int id)
        {
            return clienteDataAccess.ObtenerClientePorId(id);
        }

        public List<object> ObtenerClientesFiltrados(string searchText)
        {
            return clienteDataAccess.ObtenerClientesFiltrados(searchText);
        }
    }
}
