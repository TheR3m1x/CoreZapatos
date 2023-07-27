using DataAccess;
using System;
using System.Data;

namespace Dominio
{
    public class CuentasPorCobrarDomain
    {
        private CuentasPorCobrarDataAccess cuentasPorCobrarDataAccess;

        public CuentasPorCobrarDomain()
        {
            cuentasPorCobrarDataAccess = new CuentasPorCobrarDataAccess();
        }

        public DataTable ObtenerTodasCuentasPorCobrar()
        {
            return cuentasPorCobrarDataAccess.ObtenerTodasLasCuentasPorCobrar();
        }

        public DataRow ObtenerCuentaPorCobrarPorId(int idCuentaPorCobrar)
        {
            return cuentasPorCobrarDataAccess.ObtenerCuentaPorCobrarPorId(idCuentaPorCobrar);
        }

        public DataTable BuscarCuentasPorCobrar(string searchText)
        {
            return cuentasPorCobrarDataAccess.BuscarCuentasPorCobrar(searchText);
        }

        public bool InsertarCuentaPorCobrar(int idCliente, DateTime fechaEmision, int productoId, string descripcion, decimal montoTotal, decimal montoPagado)
        {
            return cuentasPorCobrarDataAccess.InsertarCuentaPorCobrar(idCliente, fechaEmision, productoId, descripcion, montoTotal, montoPagado);
        }

        public bool ActualizarCuentaPorCobrar(int idCuentaPorCobrar, int idCliente, DateTime fechaEmision, int productoId, string descripcion, decimal montoTotal, decimal montoPagado)
        {
            return cuentasPorCobrarDataAccess.ActualizarCuentaPorCobrar(idCuentaPorCobrar, idCliente, fechaEmision, productoId, descripcion, montoTotal, montoPagado);
        }

        public bool EliminarCuentaPorCobrar(int idCuentaPorCobrar)
        {
            return cuentasPorCobrarDataAccess.EliminarCuentaPorCobrar(idCuentaPorCobrar);
        }
    }
}
