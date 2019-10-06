using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Validacao
{
    public class FuncoesValidacao
    {
        public bool ValidarNome(string Nome)
        {
            Regex Validar = new Regex("^[A-Za-záãéêíóõúçÁÃÉÊÍÓÕÚÇ ]+$");
            if (Validar.IsMatch(Nome) == true)
                return true;
            else
                return false;
        }
        public bool ValidarTelefone(string Telefone)
        {
            Regex Validar = new Regex(@"^[2|3]\d{8}");
            if (Validar.IsMatch(Telefone)==true)
                return true;
            else
                return false;
        }
        public bool ValidarTelemovel(string Telemovel)
        {
            Regex validar = new Regex(@"^[9][1|2|3|6]\d{7}");
            if (validar.IsMatch(Telemovel) == true)
            {
                return true;
            }
            else
                return false;
        }
        public bool ValidarNIF(string NIF)
        {
            Regex validar = new Regex(@"^[1|9]\d{9}");
            if (validar.IsMatch(NIF)==true)
                return true;
            else
                return false;
        }
        public bool ValidarEmail(string Email)
        {
            Regex validar = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (validar.IsMatch(Email) == true)
                return true;
            else
                return false;
        }
        public bool ValidarCodigoPostal(string CodigoPostal)
        {
            Regex validar = new Regex(@"^[1-9]\d{3}(-\d{3})?$");
            if (validar.IsMatch(CodigoPostal) == true)
                return true;
            else
                return false;
        }
    }
}
