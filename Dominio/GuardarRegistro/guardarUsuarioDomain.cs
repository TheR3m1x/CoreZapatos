using Comun.Cache;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class guardarUsuarioDomain
    {
        GuardarUsuarios GU = new GuardarUsuarios();
        public bool InsertarUsuarios(string username, string password, int rol, string genero, string nombreUser, string apellidoUser, string emailUser, string cedulaUser)
        {
            return GU.InsertarUsuario(username, password, rol, genero, nombreUser, apellidoUser, emailUser, cedulaUser);
        }

        public bool ActualizarUsuario(int id, string username, string password, int rol, string genero, string nombreUser, string apellidoUser, string emailUser, string cedulaUser)
        {
            return GU.ActualizarUsuario(id, username, password, rol, genero, nombreUser, apellidoUser, emailUser, cedulaUser);
        }

        public bool EliminarUsuario(int id)
        {
            return GU.EliminarUsuario(id);
        }


    }



}
