using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dao;

namespace Control
{
    public class ComentarioController
    {
        public Dictionary<Int64, Comentario> ListarComentariosDeCapitulo(Capitulo c)
        {
            try
            {
                Dictionary<Int64, Comentario> mapaComentarios = new Dictionary<Int64, Comentario>();
                ComentarioDAO dao = new ComentarioDAO();

                foreach (Comentario o in dao.ListarPorCapitulo(c.id))
                {
                    mapaComentarios.Add(o.id, o);
                }

                return mapaComentarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean InserirBD(Comentario _objeto)
        {
            try
            {
                ComentarioDAO dao = new ComentarioDAO();

                return dao.InserirBD(_objeto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean RemoverBD(int _id)
        {
            try
            {
                ComentarioDAO dao = new ComentarioDAO();

                return dao.DeletarBD(_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
