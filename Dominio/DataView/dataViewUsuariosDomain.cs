using Comun.Cache;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class dataViewUsuariosDomain
    {
        
        public DataTable viewDataUsuarioDomain()
        {
            dataViewUsuarios GU = new dataViewUsuarios();
            return GU.viewDataUsuarioDA();
        }

        public DataTable ObtenerUsuarioPorIdDomain(int id)
        {
            dataViewUsuarios dataAccess = new dataViewUsuarios();
            return dataAccess.ObtenerUsuarioPorId(id);
        }
        public List<object> ObtenerUsuariosFiltrados(string searchText)
        {
            dataViewUsuarios GU = new dataViewUsuarios();

            // Llamar al método en la capa de acceso a datos para obtener los datos filtrados
            List<object> usuarios = GU.ObtenerUsuariosFiltrados(searchText);

            return usuarios;
        }


    }





}
