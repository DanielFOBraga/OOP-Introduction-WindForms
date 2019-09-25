using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class MinnhasClasses
    {
    }
    public class Empregado
    {
        private static int _numEmp;
        public Empregado()
        {
            Nome = string.Empty;
            dataNascimento = new DateTime(1900,1,1);
            Departamento = "";
            Salario = 0;
            _numEmp++;
        }
        public Empregado(string Nome, DateTime dataNascimento)
        {
            this.Nome = Nome;
            this.dataNascimento = dataNascimento;
            _numEmp++;
        }
        public Empregado(string Nome, decimal Salario)
        {
            this.Nome = Nome;
            this.Salario = Salario;
            _numEmp++;
        }
        public Empregado(string Nome, decimal Salario, DateTime dataNascimento, string Departamento)
        {
            new Empregado(Nome, Salario);
            this.dataNascimento = dataNascimento;
            this.Departamento = Departamento;
        }
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private DateTime _dataNascimento;

        public DateTime dataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }
        private string _departamento;

        public string Departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }

        private decimal _salario;

        public decimal Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }             

        public byte Idade
        {
            get
            {
                int dias = (int)DateTime.Now.Subtract(_dataNascimento).TotalDays;
                byte anos = (byte)(dias / 365.25);
                return anos;
            }
        }
        public string imprimeTodosDados()
        {
            return $"{_nome}, {Idade}, {_departamento}, {_salario}, {_dataNascimento.ToShortDateString()}, {_numEmp}";
        }
        public string imprimeDados()
        {
            return $"{_nome}, {_salario}, {_numEmp}";
        }
        public void AumentaSalario(int valor)
        {

        }
        public void AumentaSalario(decimal percentagem)
        {

        }
    }
}
