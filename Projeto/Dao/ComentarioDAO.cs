using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlServerCe;
namespace Dao
{
    public class ComentarioDAO
    {
        public List<Comentario> ListarPorCapitulo(Int32 _id)
        {
            List<Comentario> listaComentarios = new List<Comentario>();
            List<int> listaids = new List<int>();
            try
            {
                String SQL = "SELECT id,texto,criado,id_usuario FROM Comentario where id_capitulo = "+_id+";";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Comentario c = new Comentario();

                    c.id = data.GetInt32(0);
                    c.Texto = data.GetString(1);
                    c.criado = data.GetDateTime(2);

                    listaids.Add(data.GetInt32(3));


                    listaComentarios.Add(c);
                }

                data.Close();
                BD.FecharConexao();

                int i=0;
                foreach (Comentario comentario in listaComentarios){
                 UsuarioDAO DaoUsuario = new UsuarioDAO();
                 comentario.Usuario = DaoUsuario.BuscarPorID(listaids[i]);
                    i+=1;
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaComentarios;
        }

        public Boolean DeletarBD(Int64 _id)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("DELETE FROM Comentario WHERE id = {0};", _id);

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

        public Boolean InserirBD(Comentario _objeto)
        {
            try
            {
                String SQL = "INSERT INTO Comentario (texto, id_usuario, id_capitulo)"
                                 + "VALUES (@texto, @usuario, @capitulo);";

                List<SqlCeParameter> parametros = new List<SqlCeParameter>();

                parametros.Add(new SqlCeParameter("@texto", _objeto.Texto));
                parametros.Add(new SqlCeParameter("@usuario", _objeto.Usuario.Id));
                parametros.Add(new SqlCeParameter("@capitulo", _objeto.Capitulo.id));

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
