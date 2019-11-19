using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dao;

namespace Control
{
    public class HistoriaController
    {
        public Dictionary<Int64, Historia> ListarHistorias()
        {
            try
            {
                Dictionary<Int64, Historia> mapaHistorias = new Dictionary<Int64, Historia>();
                HistoriaDAO dao = new HistoriaDAO();

                foreach (Historia o in dao.ListarTodos())
                {
                    mapaHistorias.Add(o.id, o);
                }

                return mapaHistorias;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean AlterarBD(Historia _objeto)
        {
            try
            {
                HistoriaDAO dao = new HistoriaDAO();

                return dao.AlterarBD(_objeto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean InserirBD(Historia _objeto)
        {
            try
            {
                HistoriaDAO dao = new HistoriaDAO();

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
                HistoriaDAO dao = new HistoriaDAO();

                return dao.DeletarBD(_id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
