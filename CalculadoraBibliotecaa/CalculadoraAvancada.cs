using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjCalculadoraConsole;

namespace CalculadoraBibliotecaa
{
    public class CalculadoraAvancada : Calculadora
    {
        public double Potencia(double baseNum, double expoente)
        {
            return Math.Pow(baseNum, expoente);
        }
    }
}
