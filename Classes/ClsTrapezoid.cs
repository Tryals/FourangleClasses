using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourangleClasses.Classes
{
    internal class ClsTrapezoid: ClsFourangle
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private double sideD;
        private double diagonal1;
        private double diagonal2;
        public void SidesCalculation()
        {
            sideA = Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
            sideB = Math.Sqrt((X2 - X3) * (X2 - X3) + (Y2 - Y3) * (Y2 - Y3));
            sideC = sideA;
            sideD = Math.Sqrt((X1 - X4) * (X1 - X4) + (Y1 - Y4) * (Y1 - Y4));
            Console.WriteLine("Стороны ТРАПЕЦИИ");
            Console.WriteLine($"Сторона A={Math.Round(sideA, 2)}");
            Console.WriteLine($"Сторона B={Math.Round(sideB, 2)}");
            Console.WriteLine($"Сторона C={Math.Round(sideC, 2)}");
            Console.WriteLine($"Сторона D={Math.Round(sideD, 2)}");
        }
        public double Perimetr()
        {
            return sideA+sideB+sideC+sideD;
        }
        public void DiagonalsCalculation()
        {
            diagonal1 = Math.Sqrt((X1 - X3) * (X1 - X3) + (Y1 - Y3) * (Y1 - Y3));
            diagonal2 = Math.Sqrt((X2 - X4) * (X2 - X4) + (Y2 - Y4) * (Y2 - Y4));

            Console.WriteLine($"Диагональ1 ={Math.Round(diagonal1, 2)}");
            Console.WriteLine($"Диагональ2 ={Math.Round(diagonal2, 2)}");

        }
        public double Ploshad()
        {

            double s = 0;
            s = (sideD + sideB)/2 * ((X1 - X2) * (X1 - X2) + (Y2 - Y3) * (Y2 - Y3));

            return s;
        }

    }
}
