using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    #region Atributos
    public class Capitulo
    {
        public int id { get; set; }

        public Historia historia { get; set; }

        public String Observacoes { get; set; }

        public int ordem { get; set; }

        public String Texto { get; set; }

        public String Titulo { get; set; }

        public List<Comentario> Comentarios { get; set; }
    }
    #endregion
}
