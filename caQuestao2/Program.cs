using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando os numeros complexos
            NumComplexo z1 = new NumComplexo(1, 1);
            NumComplexo z2 = new NumComplexo(3, -1);

            NumComplexo z3 = new NumComplexo();
            NumComplexo z4 = new NumComplexo();

            z3 = z1.soma(z2);
            z4 = z1.vezes(z2);

            z3.ImprimeFormaPolar();
            z4.ImprimeFormaPolar();
        }
    }
}
