using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calcula
    {
        public static string Acheoperacao(double a, double b, char op)
        {
            switch (op)
            {
                case '+': return (Convert.ToString(a + b));
                case '-': return (Convert.ToString(a - b));
                case '*': return (Convert.ToString(a * b));
                case '/': 
                    if (b==0)
                    {
                        return ("Erro!!");
                    }
                    else
                    {
                        return (Convert.ToString(a / b));
                    }
                default: return (" ");
            }
        }
    }
}
