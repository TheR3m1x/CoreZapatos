using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;

namespace Dominio
{
    public class FacturasDominio
    {
        private FacturasDataAccess facturasDataAccess;

        public FacturasDominio()
        {
            facturasDataAccess = new FacturasDataAccess();
        }

        public DataTable ObtenerTodasLasFacturas()
        {
            return facturasDataAccess.ObtenerTodasLasFacturas();
        }

        public DataRow ObtenerFacturaPorId(int idFactura)
        {
            return facturasDataAccess.ObtenerFacturaPorId(idFactura);
        }

        public bool InsertarFactura(int idCliente, DateTime fecha, decimal total, int productoId, string descripcion, decimal precioUnitario, int cantidad)
        {
            return facturasDataAccess.InsertarFactura(idCliente, fecha, total, productoId, descripcion, precioUnitario, cantidad);
        }

        public bool ActualizarFactura(int idFactura, int idCliente, DateTime fecha, decimal total, int productoId, string descripcion, decimal precioUnitario, int cantidad)
        {
            return facturasDataAccess.ActualizarFactura(idFactura, idCliente, fecha, total, productoId, descripcion, precioUnitario, cantidad);
        }

        public bool EliminarFactura(int idFactura)
        {
            return facturasDataAccess.EliminarFactura(idFactura);
        }
    }
}
