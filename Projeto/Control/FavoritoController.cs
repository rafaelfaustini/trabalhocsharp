using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dao;

namespace Control
{
    public class FavoritoController
    {
        public Dictionary<Int64, Favorito> ListarFavoritosDeUsuario(Usuario u)
        {
            try
            {
                Dictionary<Int64, Favorito> mapaFavoritos = new Dictionary<Int64, Favorito>();
                FavoritoDAO dao = new FavoritoDAO();

                foreach (Favorito o in dao.BuscarFavoritosPorUsuario(u.Id))
                {
                    mapaFavoritos.Add(o.Usuario.Id, o);
                }

                return mapaFavoritos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean InserirBD(Favorito _objeto)
        {
            try
            {
                FavoritoDAO dao = new FavoritoDAO();

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
                FavoritoDAO dao = new FavoritoDAO();

                return dao.DeletarBD(_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
