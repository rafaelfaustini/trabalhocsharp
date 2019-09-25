using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        #region Atributos
        public int Id { get; set; }

        public String Username { get; set; }

        public String Email { get; set; }

        public String Senha { get; set; }

        public String DisplayName { get; set; }

        public Boolean ativado { get; set; }
        #endregion
    }
}
