using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloEJ02
{
    public class Triangulo
    {
        
        private int LadoB;
        private int LadoC;
        private int LadoA;

        public Triangulo(int ladoA, int ladoB, int ladoC)
        {
            this.LadoA = ladoA;
            this.LadoB = ladoB;
            this.LadoC = ladoC;
        }

        public Triangulo()
        {
            LadoA = 1;
            LadoB = 1;
            LadoC = 1;
        }
        public bool Validar()
        {
            return LadoA + LadoB > LadoC &&
                LadoA + LadoC > LadoB &&
                LadoB + LadoC > LadoA;
        }

        public string QueTipoDeTriangulo()
        {
            if (Math.Pow(this.LadoA,2)== Math.Pow(this.LadoB, 2)+ Math.Pow(this.LadoC, 2))
            {
                return "Es un triangulo Rectangulo";
            }
            else if (Math.Pow(this.LadoA, 2) > Math.Pow(this.LadoB, 2) + Math.Pow(this.LadoC, 2))
            {
                return "Es un triangulo Obtusangulo";
            }
            else if (Math.Pow(this.LadoA, 2) < Math.Pow(this.LadoB, 2) + Math.Pow(this.LadoC, 2))
            {
                return "Es un triangulo Acutangulo";
            }
            return "Valor mal ingresado";
        }
        public double ObtenerSemiPerimetro()
        {
            return (LadoA + LadoB + LadoC) / 2;
        }
        public double GetArea()
        {
            return Math.Sqrt((ObtenerSemiPerimetro() * (ObtenerSemiPerimetro() - LadoA) * (ObtenerSemiPerimetro() - LadoB) * (ObtenerSemiPerimetro() - LadoC)));

        }

        public double GetPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }

    }
}
