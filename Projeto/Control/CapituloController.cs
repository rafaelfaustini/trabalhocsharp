using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dao;

namespace Control
{
    public class CapituloController
    {
        public Dictionary<Int64, Capitulo> ListarCapituloDeHistoria(Historia h)
        {
            try
            {
                Dictionary<Int64, Capitulo> mapaCapitulos = new Dictionary<Int64, Capitulo>();
                CapituloDAO dao = new CapituloDAO();
                List<Capitulo> lista = dao.BuscarCapitulosPorHistoria(h);

                foreach (Capitulo o in lista)
                {
                    mapaCapitulos.Add(o.id, o);
                }

                return mapaCapitulos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean InserirBD(Capitulo _objeto)
        {
            try
            {
                CapituloDAO dao = new CapituloDAO();

                return dao.InserirBD(_objeto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean AlterarBD(Capitulo _objeto)
        {
            try
            {
                CapituloDAO dao = new CapituloDAO();
               
                return dao.AlterarBD(_objeto);
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
                CapituloDAO dao = new CapituloDAO();

                return dao.DeletarBD(_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
