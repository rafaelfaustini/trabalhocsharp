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

        public Boolean InserirBD(Favorito _objeto)
        {
            try
            {
                String SQL = "INSERT INTO Favorito (usuario_id, historia_id)"
                                 + "VALUES (@usuario_id, @historia_id);";

                List<SqlCeParameter> parametros = new List<SqlCeParameter>();

                parametros.Add(new SqlCeParameter("@usuario_id", _objeto.Usuario.Id));
                parametros.Add(new SqlCeParameter("@historia_id", _objeto.Historia.id));


                Int32 idInserido = BD.ExecutarInsertComRetornoID(SQL, parametros);

                if (idInserido != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
