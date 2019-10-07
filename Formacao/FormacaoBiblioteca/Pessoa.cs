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
        public bool Certificacao { get; set; }
        public decimal ValorHora { get; set; }
        public List<Curso> Cursos { get; set; }
        public enum TaxasIVA
        {
            Reduzida = 6,
            Intermedia = 13,
            Normal = 23
        }
        public virtual decimal ValorFinal(TaxasIVA IVA)
        {
            return ValorHora + (ValorHora * (decimal)IVA / 100);
        }
    }
    public class Curso
    {
        public string Designacao { get; set; }
        public int Horas { get; set; }
        public string Descricao { get; set; }
    }
    public class FormadorInformatica : Formador
    {
        public bool CertificacaoArea { get; set; }
        public override decimal ValorFinal(TaxasIVA IVA)
        {
            return base.ValorFinal(IVA) + 2;
        }

    }
}

