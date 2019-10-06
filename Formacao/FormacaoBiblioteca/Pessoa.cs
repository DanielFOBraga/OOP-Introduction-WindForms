using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormacaoBiblioteca
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int NIF { get; set; }
        public string Email { get; set; }
        public List<Telefone> Contactos { get; set; }
        public override string ToString()
        {
            return Nome + " - " + NIF.ToString();
        }
    }
    public class Telefone
    {
        public int Numero { get; set; }
        public string Descricao { get; set; }
    }
    public class Formador : Pessoa
    {
        public string AreaFormacao { get; set; }
        public decimal ValorHora { get; set; }
    }

}

