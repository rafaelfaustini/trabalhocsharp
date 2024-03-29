﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    #region Atributos
    public class Historia
    {
        public int id { get; set; }

        public Usuario Autor { get; set; }

        public Boolean Terminada { get; set; }

        public DateTime Data { get; set; }

        public String Titulo { get; set; }

        public String Sinopse { get; set; }

        public List<Capitulo> Capitulos { get; set; }
    }
    #endregion
}
