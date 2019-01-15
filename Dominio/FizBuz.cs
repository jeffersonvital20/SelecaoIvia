using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class FizBuz
    {
        public string Retorno(int numero)
        {
            if (numero % 3 == 0 && numero % 5 == 0)
                return "FIZBUZ";

            if (numero % 3 == 0)
                return "FIZ";

            if (numero % 5 == 0)
                return "BUZ";

            return numero.ToString();
        }   
    }
}
