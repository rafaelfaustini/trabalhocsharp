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
                BD.FecharConexao();


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


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return u;
        }


        public Boolean AlterarBD(Usuario _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE Usuario SET username = '{0}', email = '{1}', senha = '{2}', displayname = '{3}' WHERE id = {4};",
                    _objeto.Username,
                    _objeto.Email,
                    _objeto.Senha,
                    _objeto.DisplayName,
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

        public Boolean InserirBD(Usuario _objeto)
        {
            try
            {
                String SQL = "INSERT INTO Usuario (username, email, senha, displayname)"
                                 + "VALUES (@username, @email, @senha, @displayname);";

                List<SqlCeParameter> parametros = new List<SqlCeParameter>();

                parametros.Add(new SqlCeParameter("@username", _objeto.Username));
                parametros.Add(new SqlCeParameter("@email", _objeto.Email));
                parametros.Add(new SqlCeParameter("@senha", _objeto.Senha));
                parametros.Add(new SqlCeParameter("@displayname", _objeto.DisplayName));

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
    }
}
