using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double t1, t2,t3, figura;
            

            Console.WriteLine("1- Trapezio \n2- Triangulo \n3- Losango \nDigite o Codigo de qual figura geométrica deseja: ");
            figura = int.Parse(Console.ReadLine());

            
            switch (figura)
            {
                case 1:
                   figura= 1;
                    Console.WriteLine("\nVocê escolheu o Trapezio");

                    Console.WriteLine("\nDigite o primeiro valor: ");
                    t1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo valor: ");
                    t2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o terceiro valor: ");
                    t3 = double.Parse(Console.ReadLine());

                    Console.WriteLine("A area do Trapezio é: " + (t1 + t2 * t3) / 2);
                    
                    break;

                    case 2:
                    figura = 2;
                    Console.WriteLine("\nVocê escolheu o Triângulo");

                    Console.WriteLine("\nDigite o primeiro valor: ");
                    t1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite o primeiro valor: ");
                    t2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("A area do Triângulo é: " + (t1 * t2)/ 2);
                    break;

                case 3:
                    figura = 3;
                    Console.WriteLine("\nVocê escolheu o Losango");

                    Console.WriteLine("\nDigite o primeiro valor: ");
                    t1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite o primeiro valor: ");
                    t2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("A area do Losango é: " + (t1 * t2) / 2);
                    break;
            }

            

            Console.ReadKey();
        }
    }
}
