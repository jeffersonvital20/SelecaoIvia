using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class PalavrasPrimas
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        
        public PalavrasPrimas()
        {
            dic.Add(1, "a");
            dic.Add(2, "b");
            dic.Add(3, "c");
            dic.Add(4, "d");
            dic.Add(5, "e");
            dic.Add(6, "f");
            dic.Add(7, "g");
            dic.Add(8, "h");
            dic.Add(9, "i");
            dic.Add(10, "j");
            dic.Add(11, "k");
            dic.Add(12, "l");
            dic.Add(13, "m");
            dic.Add(14, "n");
            dic.Add(15, "o");
            dic.Add(16, "p");
            dic.Add(17, "q");
            dic.Add(18, "r");
            dic.Add(19, "s");
            dic.Add(20, "t");
            dic.Add(21, "u");
            dic.Add(22, "v");
            dic.Add(23, "w");
            dic.Add(24, "x");
            dic.Add(25, "y");
            dic.Add(26, "z");
            dic.Add(27, "A");
            dic.Add(28, "B");
            dic.Add(29, "C");
            dic.Add(30, "D");
            dic.Add(31, "E");
            dic.Add(32, "F");
            dic.Add(33, "G");
            dic.Add(34, "H");
            dic.Add(35, "I");
            dic.Add(36, "J");
            dic.Add(37, "K");
            dic.Add(38, "L");
            dic.Add(39, "M");
            dic.Add(40, "N");
            dic.Add(41, "O");
            dic.Add(42, "P");
            dic.Add(43, "Q");
            dic.Add(44, "R");
            dic.Add(45, "S");
            dic.Add(46, "T");
            dic.Add(47, "U");
            dic.Add(48, "V");
            dic.Add(49, "W");
            dic.Add(50, "X");
            dic.Add(51, "Y");
            dic.Add(52, "Z");
        }

        public int RetornarValorLetra(string str)
        {
            for (int i = 1; i < dic.Count+1; i++)
            {
                if (str == dic[i])
                {
                    return i;
                }
            }
            
            return 0;
        }

        public int RetornarSomaPalavra(string palavra)
        {
            int soma = 0;
            foreach (var letra in palavra)
            {
                soma += RetornarValorLetra(letra.ToString());
            }
            return soma;
        }
        public bool VerificaPalavraPrima(string palavra)
        {
            int numeroPalavra = RetornarSomaPalavra(palavra);
            int cont = 0;
            for (int i = 1; i <= numeroPalavra; i++)
            {
                if (numeroPalavra%i ==0)
                {
                    cont++;
                }
            }
            if (cont == 2)
                return true;
            else
                return false;
        }

    }
}
