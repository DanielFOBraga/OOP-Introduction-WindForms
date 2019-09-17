using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class ClassesUtil
    {
        public static string PrimeiroUltimo(string Nome)
        {
            string resultado = "";
            string[] nomes = Nome.Split(' ');

            //verificar se o Array tem conteúdo

            if (nomes.Length > 0)
            {
                string primeiro = nomes[0].ToString().ToUpper();
                int ultima_posicao = nomes.Length - 1;
                string ultimo = nomes[ultima_posicao].ToString().ToUpper();
                resultado = $"{primeiro} {ultimo}".ToUpper();
            }
            return resultado;
        }
        public static string Email1(string Nome)
        {
            string resultado = "";
            string[] nomes = Nome.Split(' ');

            //verificar se o Array tem conteúdo

            if (nomes.Length > 0)
            {
                string primeiro = nomes[0].ToString().ToUpper();
                int ultima_posicao = nomes.Length - 1;
                string ultimo = nomes[ultima_posicao].ToString().ToUpper();
                resultado = $"{primeiro.ToLower()}.{ultimo.ToLower()}@xpto.pt";
            }
            return resultado;           
        }
        public static string Email2(string Nome)
        {
            string resultado = "";
            string[] nomes = Nome.Split(' ');

            //verificar se o Array tem conteúdo

            if (nomes.Length > 0)
            {
                string primeiro = nomes[0].ToString().ToUpper();
                int ultima_posicao = nomes.Length - 1;
                string ultimo = nomes[ultima_posicao].ToString().ToUpper();
                resultado = $"{(primeiro.ToLower())[0]}{ultimo.ToLower()}@xpto.pt";
            }
            return resultado;
        }
        public static string RemoverEspacos(string Frase)
        {
            Frase = System.Text.RegularExpressions.Regex.Replace(Frase, @"\s+", " ");
            return Frase;
        }
        public static string SubstituirCaracteresEspeciais(string Frase)
        {
            //definir lista de caracteres a substituir
            Dictionary<char, char> Caracteres = new Dictionary<char, char>();
            Caracteres.Add('á', 'a');
            Caracteres.Add('à', 'a');
            Caracteres.Add('ã', 'a');

            Caracteres.Add('Á', 'A');
            Caracteres.Add('À', 'A');
            Caracteres.Add('Ã', 'A');

            Caracteres.Add('é', 'e');
            Caracteres.Add('ê', 'e');

            Caracteres.Add('É', 'E');
            Caracteres.Add('Ê', 'E');

            Caracteres.Add('í', 'i');
            Caracteres.Add('Í', 'I');

            Caracteres.Add('ó', 'o');
            Caracteres.Add('õ', 'o');

            Caracteres.Add('Ó', 'O');
            Caracteres.Add('Õ', 'O');

            Caracteres.Add('ú', 'u');
            Caracteres.Add('Ú', 'U');

            Caracteres.Add('ç', 'c');
            Caracteres.Add('Ç', 'C');

            foreach (KeyValuePair<char, char> item in Caracteres)
            {
                Frase.Replace(item.Key, item.Value);
            }

            return Frase;
        }

    }
}
 