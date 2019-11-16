using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dao;

namespace Control
{
    public class UsuarioController
    {
        public Dictionary<Int64, Usuario> ListarUsuarios()
        {
            try
            {
                Dictionary<Int64, Usuario> mapaUsuarios = new Dictionary<Int64, Usuario>();
                UsuarioDAO dao = new UsuarioDAO();

                foreach (Usuario o in dao.ListarTodos())
                {
                    mapaUsuarios.Add(o.Id, o);
                }

                return mapaUsuarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean InserirBD(Usuario _objeto)
        {
            bool resultado = false;
            try
            {
                UsuarioDAO dao = new UsuarioDAO();

                return dao.InserirBD(_objeto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
