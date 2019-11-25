using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlServerCe;

namespace Dao
{
    public class CapituloDAO
    {
        public List<Capitulo> BuscarCapitulosPorHistoria(Historia h)
        {
            List<Capitulo> listaCapitulos = new List<Capitulo>();
            try
            {
                String SQL = "SELECT id,observacoes,ordem,texto,titulo FROM Capitulo where historia="+h.id+";";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);



                while (data.Read())
                {
                    Capitulo c = new Capitulo();

                    c.id = data.GetInt32(0);
                    c.historia = h;
                    c.Observacoes = data.GetString(1);
                    c.ordem = data.GetInt32(2);
                    c.Texto = data.GetString(3);
                    c.Titulo = data.GetString(4);



                    listaCapitulos.Add(c);
                }

                data.Close();
                BD.FecharConexao();



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            return listaCapitulos;
        }

        public Boolean AlterarBD(Capitulo _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE Capitulo SET historia = {0}, observacoes = '{1}', ordem = {2}, texto = '{3}', titulo = '{4}' WHERE id = {5};",
                    _objeto.historia,
                    _objeto.Observacoes,
                    _objeto.ordem,
                    _objeto.Texto,
                    _objeto.Titulo,
                    _objeto.id);



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
                String SQL = String.Format("DELETE FROM Capitulo WHERE id = {0};", _id);

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

        public Boolean InserirBD(Capitulo _objeto)
        {
            try
            {
                String SQL = "INSERT INTO Capitulo (historia, observacoes, ordem, texto, titulo)"
                                 + "VALUES (@historia, @observacoes, @ordem, @texto, @titulo);";

                List<SqlCeParameter> parametros = new List<SqlCeParameter>();

                parametros.Add(new SqlCeParameter("@historia", _objeto.historia.id));
                parametros.Add(new SqlCeParameter("@observacoes", _objeto.Observacoes));
                parametros.Add(new SqlCeParameter("@ordem", _objeto.ordem));
                parametros.Add(new SqlCeParameter("@texto", _objeto.Texto));
                parametros.Add(new SqlCeParameter("@titulo", _objeto.Titulo));


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
