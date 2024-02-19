using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao2
{
    internal class NumComplexo
    {
        // Atributos
        double Re;
        double Im;

        // getters e setter
        public double Re1 { get => Re; set => Re = value; }
        public double Im1 { get => Im; set => Im = value; }

        // construtores
        public NumComplexo()
        {

        }

        public NumComplexo(double re, double im)
        {
            Re = re;
            Im = im;
        }

        // Métodos

        public NumComplexo soma(NumComplexo num2)
        {
            NumComplexo num_temp = new NumComplexo();

            num_temp.Re = this.Re + num2.Re;
            num_temp.Im = this.Im + num2.Im;

            return num_temp;
        }

        public NumComplexo vezes(NumComplexo num2)
        {
            NumComplexo num_temp = new NumComplexo();

            num_temp.Re = (this.Re * num2.Re) - (this.Im * num2.Im);
            num_temp.Im = (this.Re * num2.Im) + (this.Im * num2.Re);

            return num_temp;

        }

        public double Modulo()
        {

            double modulo = Math.Sqrt(Math.Pow(this.Re, 2) + Math.Pow(this.Im, 2));
            return modulo;
            
        }

        public double Argumento()
        {
            double argumento;

            argumento = Math.Atan(this.Im / this.Re);
            return argumento;
        }

        public void ImprimeFormaPolar()
        {
            double modulo = this.Modulo();
            double angulo = this.Argumento();
            Console.WriteLine("A forma polar do número é: ");
            Console.WriteLine(modulo + "(cos" + angulo + "+ isin " + angulo + ")");
            Console.ReadLine();
        }
        
    }
}
