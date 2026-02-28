using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char continuar;

            do
            {
                Console.Clear();
                Console.WriteLine("===== CALCULADORA BÁSICA =====");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.Write("Seleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el primer número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("Resultado de la suma: " + resultado);
                        break;

                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("Resultado de la resta: " + resultado);
                        break;

                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("Resultado de la multiplicación: " + resultado);
                        break;


                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("Resultado de la división: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;

                }

                Console.Write("\n¿Desea continuar? (S/N): ");
                continuar = char.ToUpper(Console.ReadKey().KeyChar);

            } while (continuar == 'S');

            Console.WriteLine("\n\nPrograma finalizado.");
            Console.ReadKey();
        }
    }
}

