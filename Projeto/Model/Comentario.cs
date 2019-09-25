using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Comentario
    {
        #region Atributos
        public int id { get; set; }

        public String Texto { get; set; }

        public DateTime criado { get; set; }

        public Usuario Usuario { get; set; }

        public Capitulo Capitulo { get; set; }

        #endregion
    }
}
