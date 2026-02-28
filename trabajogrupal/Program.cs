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
                    

                  
                }

                Console.Write("\n¿Desea continuar? (S/N): ");
                continuar = char.ToUpper(Console.ReadKey().KeyChar);

            } while (continuar == 'S');

            Console.WriteLine("\n\nPrograma finalizado.");
            Console.ReadKey();
        }
    }
}

