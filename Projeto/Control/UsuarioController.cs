using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dao;

namespace Control
{
    class UsuarioController
    {
        public Boolean SalvarUsuarioNoArquivo(Usuario _p)
        {
            try
            {
                UsuarioDAO dao = new UsuarioDAO();

                dao.SalvarUsuarioNoArquivo(_p);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dictionary<Int64, Usuario> ListarUsuariosDoArquivo()
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

                return dao.InserirBDParametros(_objeto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
