using DataAccess.GuardarRegistro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.GuardarRegistro
{
    public class registrosClientesDominio
    {
        private guardarClientes guardarClientes;

        public registrosClientesDominio()
        {
            guardarClientes = new guardarClientes();
        }

        public bool InsertarCliente(string nombre, string apellido, string email, string telefono, string direccion, string cedula)
        {
            return guardarClientes.InsertarCliente(nombre, apellido, email, telefono, direccion, cedula);
        }

        public bool ActualizarCliente(int id, string nombre, string apellido, string email, string telefono, string direccion, string cedula)
        {
            return guardarClientes.ActualizarCliente(id, nombre, apellido, email, telefono, direccion, cedula);
        }

        public bool EliminarCliente(int id)
        {
            return guardarClientes.EliminarCliente(id);
        }
    }
}
