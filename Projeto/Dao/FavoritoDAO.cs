using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlServerCe;

namespace Dao
{
    public class FavoritoDAO
    {
            public Favorito BuscarPorID(Int64 _idhistoria)
            {
                Favorito f = null;
                Historia h = null;
                Usuario u = null;
                try
                {

                    String SQL = String.Format("SELECT id_usuario from favorito where id_historia = {0}", _idhistoria);

                    SqlCeDataReader data = BD.ExecutarSelect(SQL);

                    if (data.Read())
                    {
                        HistoriaDAO daoHistoria = new HistoriaDAO();
                        h = daoHistoria.BuscarPorID(_idhistoria);

                        UsuarioDAO daoUsuario = new UsuarioDAO();
                        u = daoUsuario.BuscarPorID(data.GetInt32(0));

                        f = new Favorito();
                        f.Historia = h;
                        f.Usuario = u;
                    }

                    data.Close();
                    BD.FecharConexao();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                return f;
            }

            public Boolean InserirBD(Favorito _objeto)
            {
                bool resultado = false;
                try
                {
                    String SQL = String.Format("INSERT INTO Favorito (descricao) VALUES ('{0}')", _objeto.Logradouro);

                    int linhaAfetadas = BD.ExecutarIDU(SQL);

                    if (linhaAfetadas > 0)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                return resultado;
            }

            public Boolean DeletarBD(Int64 _id)
            {
                bool resultado = false;
                try
                {
                    String SQL = String.Format("DELETE FROM Favorito WHERE id_historia = {0};", _id);

                    int linhaAfetadas = BD.ExecutarIDU(SQL);

                    if (linhaAfetadas > 0)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                return resultado;
            }

            public List<Favorito> BuscarFavoritosPorUsuario(Int64 _idUsuario)
            {
                List<Favorito> listaFavoritos = new List<Favorito>();
                try
                {
                    String SQL = String.Format("SELECT * FROM Favorito WHERE id_usuario = {0};", _idUsuario);

                    SqlCeDataReader data = BD.ExecutarSelect(SQL);

                    while (data.Read())
                    {
                        Favorito f = new Favorito();

                        UsuarioDAO daoUsuario = new UsuarioDAO();
                        f.Usuario = daoUsuario.BuscarPorID(_idUsuario);

                        HistoriaDAO daoHistoria = new HistoriaDAO();
                        f.Historia = daoHistoria.BuscarPorID(data.GetInt32(0));

                        listaFavoritos.Add(f);
                    }

                    data.Close();
                    BD.FecharConexao();

                    return listaFavoritos;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

     
}
