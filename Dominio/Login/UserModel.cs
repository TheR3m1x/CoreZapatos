using Comun.Cache;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class UserModel
    {
        UserDao userDao = new UserDao();   
        public bool LoginUser(string username, string password)
        {
            return userDao.Login(username, password);
        }

        public void metodo()
        {
            if (UserLoginCache.rol == cargos.Administrador || UserLoginCache.rol == cargos.Mantenimiento)
            {

            }

            if (UserLoginCache.rol == cargos.Usuario)
            {

            }
            if (UserLoginCache.rol == cargos.Consultas)
            {

            }

        }
    }
}
