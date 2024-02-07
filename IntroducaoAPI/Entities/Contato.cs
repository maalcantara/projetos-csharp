using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoAPI.Entities
{
    public class Contato
    {
        public Contato()
        {
            Nome = string.Empty;
            Telefone = string.Empty;
            Ativo = false;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}
