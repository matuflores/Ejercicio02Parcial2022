using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloEJ02.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Ingrese el lado A: ");
            int ladoA = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado B: ");
            int ladoB = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado C: ");
            int ladoC = int.Parse(Console.ReadLine());

            var trian2 = new Triangulo(ladoA, ladoB, ladoC);
            if (trian2.Validar())
            {
                Console.WriteLine($"El area es: {trian2.GetArea()}");
                Console.WriteLine($"El perimetro es: {trian2.GetPerimetro()}");
                Console.WriteLine($"{trian2.QueTipoDeTriangulo()}");
            }
            else
            {
                Console.WriteLine("Valores mal ingresado, reintente...");
            }

            var trian1 = new Triangulo();
            Console.WriteLine($"Area de triangulo con todos sus lados con valor 1: {trian1.GetArea()}");
            Console.WriteLine($"Perimetro de triangulo con todos sus lados con valor 1: { trian1.GetPerimetro()}");

            Console.ReadLine();

        }
    }
}
