using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Favorito
    {
        #region Atributos
        public int id { get; set; }

        public Usuario Usuario { get; set; }

        public Historia Historia { get; set; }

        #endregion
    }
}
