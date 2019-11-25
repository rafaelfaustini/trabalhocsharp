using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlServerCe;

namespace Dao
{
    public class HistoriaDAO
    {
        public List<Historia> ListarTodos()
        {
            List<Historia> listaHistorias = new List<Historia>();
            try
            {
                String SQL = "SELECT id, autor, terminada, data, titulo, sinopse FROM Historia;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                List<int>ids = new List<int>();



                while (data.Read())
                {
                    Historia h = new Historia();
                    h.id = data.GetInt32(0);
                    ids.Add(data.GetInt32(1));
                    h.Terminada = Convert.ToBoolean(data.GetByte(2));
                    h.Data = data.GetDateTime(3);
                    h.Titulo = data.GetString(4);
                    h.Sinopse = data.GetString(5);
                    listaHistorias.Add(h);
                }

                data.Close();
                BD.FecharConexao();

                int i = 0;
                foreach (Historia historia in listaHistorias) {
                    UsuarioDAO DaoUsuario = new UsuarioDAO();
                    Usuario autor = DaoUsuario.BuscarPorID(i);
                    historia.Autor = autor;
                    i+=1;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            foreach (Historia historia in listaHistorias)
            {
                CapituloDAO dao = new CapituloDAO();

                historia.Capitulos = dao.BuscarCapitulosPorHistoria(historia);


            }


            return listaHistorias;
        }

        public Historia BuscarPorID(Int64 _id)
        {
            Historia h = null;
            try
            {
                String SQL = String.Format("SELECT * FROM Historia WHERE id = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    h = new Historia();

                    h.id = data.GetInt32(0);
                    UsuarioDAO DaoUsuario = new UsuarioDAO();
                    h.Autor = DaoUsuario.BuscarPorID(data.GetInt32(1));

                    h.Terminada = data.GetBoolean(2);
                    h.Data = data.GetDateTime(3);
                    h.Titulo = data.GetString(4);
                    h.Sinopse = data.GetString(5);

                }

                data.Close();
                BD.FecharConexao();

                    CapituloDAO dao = new CapituloDAO();

                    h.Capitulos = dao.BuscarCapitulosPorHistoria(h);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return h;
        }

        public Boolean InserirBD(Historia _objeto)
        {
            try
            {
                String SQL = "INSERT INTO historia (autor, terminada, data, titulo, sinopse)"
                                 + "VALUES (@autor, @terminada, @data, @titulo, @sinopse);";

                List<SqlCeParameter> parametros = new List<SqlCeParameter>();

                parametros.Add(new SqlCeParameter("@autor", _objeto.Autor.Id));
                parametros.Add(new SqlCeParameter("@terminada", _objeto.Terminada));
                parametros.Add(new SqlCeParameter("@data", _objeto.Data));
                parametros.Add(new SqlCeParameter("@titulo", _objeto.Titulo));
                parametros.Add(new SqlCeParameter("@sinopse", _objeto.Sinopse));


                Int32 idInserido = BD.ExecutarInsertComRetornoID(SQL, parametros);

                if (idInserido != 0)
                {

                    CapituloDAO daoCapitulo = new CapituloDAO();

                    if (_objeto.Capitulos != null)
                    {
                        foreach (Capitulo end in _objeto.Capitulos)
                        {
                            daoCapitulo.InserirBD(end);
                        }
                    }

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


        public Boolean AlterarBD(Historia _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE Historia SET autor = {0}, terminada={1}, data='{2}', titulo='{3}', sinopse='{4}' WHERE id = {5};",
                    _objeto.Autor.Id,_objeto.Terminada,_objeto.Data, _objeto.Titulo, _objeto.Sinopse, _objeto.id);
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
                String SQL = String.Format("DELETE FROM Historia WHERE id = {0};", _id);

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

        public List<Historia> BuscarHistoriasPorUsuario(Int64 _idPessoa)
        {
            List<Historia> listaHistorias = new List<Historia>();
            try
            {
                String SQL = String.Format("SELECT * FROM Historia WHERE autor = {0};", _idPessoa);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Historia h = new Historia();

                    h.id = data.GetInt32(0);
                    UsuarioDAO DaoUsuario = new UsuarioDAO();
                    h.Autor = DaoUsuario.BuscarPorID(data.GetInt32(1));
                    h.Terminada = data.GetBoolean(2);
                    h.Data = data.GetDateTime(3);
                    h.Titulo = data.GetString(4);
                    h.Sinopse = data.GetString(5);

                    listaHistorias.Add(h);
                }

                data.Close();
                BD.FecharConexao();

                foreach (Historia historia in listaHistorias)
                {
                    CapituloDAO dao = new CapituloDAO();

                    historia.Capitulos = dao.BuscarCapitulosPorHistoria(historia);

                }

                return listaHistorias;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
