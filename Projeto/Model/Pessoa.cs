using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {
        #region Atributos

        public Int64 Id { set; get; }
        
        //Declaração Implícita
        public String Nome { set; get; }

        //Declaração explícita
        private String telefone;
        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public String Email { set; get; }

        public String Imagem { set; get; }

        public Int32 TipoEndereco { set; get; }

        public String Endereco  { set; get; }

        public Int32 Estado { set; get; }

        public Int32 Cidade { set; get; }

        public String Sexo { set; get; }

        public String EstadoCivil { set; get; }

        public Boolean Animais { set; get; }

        public Boolean Filhos { set; get; }

        #endregion

        #region Métodos
         //Implementação dos métodos
        #endregion
    }
}
