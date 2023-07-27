using DataAccess.DataView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DataView
{
    public class dataViewFacturasDominio
    {
        private dataViewFacturas dataViewFacturas;

        public dataViewFacturasDominio()
        {
            dataViewFacturas = new dataViewFacturas();
        }

        public DataTable ObtenerTodasFacturas()
        {
            return dataViewFacturas.ObtenerTodasFacturas();
        }

        public DataTable ObtenerFacturaPorId(int selectedId)
        {
            return dataViewFacturas.ObtenerFacturaPorId(selectedId);
        }

        public List<object> ObtenerFacturasFiltradas(string searchText)
        {
            return dataViewFacturas.ObtenerFacturasFiltradas(searchText);
        }
    }
}
