using System;
using System.Collections.Generic;
using System.Data;
using DataAccess;

namespace Domain
{
    public class CotizacionesDomain
    {
        private CotizacionesDataAccess cotizacionesDataAccess;

        public CotizacionesDomain()
        {
            cotizacionesDataAccess = new CotizacionesDataAccess();
        }

        public DataTable ObtenerTodasCotizaciones()
        {
            return cotizacionesDataAccess.ObtenerTodasLasCotizaciones();
        }

        public DataRow ObtenerCotizacionPorId(int idCotizacion)
        {
            return cotizacionesDataAccess.ObtenerCotizacionPorId(idCotizacion);
        }

        public DataTable BuscarCotizaciones(string searchText)
        {
            return cotizacionesDataAccess.BuscarCotizaciones(searchText);
        }

        public bool InsertarCotizacion(int idCliente, DateTime fecha, int productoId, string descripcion, decimal precioUnitario, int cantidad, decimal itbis, decimal descuento, decimal total)
        {
            return cotizacionesDataAccess.InsertarCotizacion(idCliente, fecha, productoId, descripcion, precioUnitario, cantidad, itbis, descuento, total);
        }

        public bool ActualizarCotizacion(int idCotizacion, int idCliente, DateTime fecha, int productoId, string descripcion, decimal precioUnitario, int cantidad, decimal itbis, decimal descuento, decimal total)
        {
            return cotizacionesDataAccess.ActualizarCotizacion(idCotizacion, idCliente, fecha, productoId, descripcion, precioUnitario, cantidad, itbis, descuento, total);
        }

        public bool EliminarCotizacion(int idCotizacion)
        {
            return cotizacionesDataAccess.EliminarCotizacion(idCotizacion);
        }
    }
}
