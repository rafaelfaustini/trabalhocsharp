using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dao
{
    public class UsuarioDAO
    {
        public List<Usuario> ListarTodos()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            try
            {
                String SQL = "SELECT id,username,senha,email,displayname FROM Usuario;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Usuario u = new Usuario();

                    u.Id = data.GetInt32(0);
                    u.Username = data.GetString(1);
                    u.Senha = data.GetString(2);
                    u.Email = data.GetString(3);
                    u.DisplayName = data.GetString(4);


                    listaUsuarios.Add(u);
                }

                data.Close();
                BD.FecharConexao();

                foreach (Usuario u in listaUsuarios)
                {
                    FavoritoDAO dao = new FavoritoDAO();

                    u.Favoritos = dao.BuscarFavoritosPorUsuario(u.Id);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaUsuarios;
        }

        public Usuario BuscarPorID(Int64 _id)
        {
            Usuario u = null;
            try
            {
                String SQL = String.Format("SELECT id,username, senha, email, displayname FROM Usuario WHERE id = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    u = new Usuario();
                    u.Id = data.GetInt32(0);
                    u.Username = data.GetString(1);
                    u.Senha = data.GetString(2);
                    u.Email = data.GetString(3);
                    u.DisplayName = data.GetString(4);

                }

                data.Close();
                BD.FecharConexao();
                FavoritoDAO DaoFavorito = new FavoritoDAO();

                u.Favoritos = DaoFavorito.BuscarFavoritosPorUsuario(u.Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return u;
        }

        public Boolean InserirBD(Usuario _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO Usuario (nome, email, telefone, sexo, estado_civil, animal, filhos) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                    _objeto.Nome,
                    _objeto.Email,
                    _objeto.Telefone,
                    _objeto.Sexo,
                    _objeto.EstadoCivil,
                    _objeto.Animais,
                    _objeto.Filhos);

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

        public Boolean AlterarBD(Usuario _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE Usuario SET nome = '{0}', email = '{1}', telefone = '{2}' WHERE id = {3};",
                    _objeto.Nome,
                    _objeto.Email,
                    _objeto.Telefone,
                    _objeto.Id);

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
                String SQL = String.Format("DELETE FROM Usuario WHERE id = {0};", _id);

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

        //INSERT COM PARAMETROS NO COMANDO E RETORNO DO ID GERADO AUTOMATICAMENTE
        public Boolean InserirBDParametros(Usuario _objeto)
        {
            try
            {
                //String SQL = "INSERT into tabela(nome)values(@nome); SELECT SCOPE_IDENTITY();");
                String SQL = "INSERT INTO Usuario (nome, email, telefone, sexo, estado_civil, animal, filhos)"
                                 + "VALUES (@nome, @email, @telefone, @sexo, @estado_civil, @animal, @filhos);";

                List<SqlCeParameter> parametros = new List<SqlCeParameter>();

                parametros.Add(new SqlCeParameter("@nome", _objeto.Nome));
                parametros.Add(new SqlCeParameter("@email", _objeto.Email));
                parametros.Add(new SqlCeParameter("@telefone", _objeto.Telefone));
                parametros.Add(new SqlCeParameter("@sexo", _objeto.Sexo));
                parametros.Add(new SqlCeParameter("@estado_civil", _objeto.EstadoCivil));
                parametros.Add(new SqlCeParameter("@animal", _objeto.Animais));
                parametros.Add(new SqlCeParameter("@filhos", _objeto.Filhos));

                Int32 idInserido = BD.ExecutarInsertComRetornoID(SQL, parametros);

                if (idInserido != 0)
                {

                    FavoritoDAO daoFavorito = new FavoritoDAO();

                    foreach (Favorito end in _objeto.Favoritos)
                    {
                        daoFavorito.InserirBD(end);
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
    }
}
