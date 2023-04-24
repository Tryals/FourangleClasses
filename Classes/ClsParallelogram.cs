using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourangleClasses.Classes
{
    internal class ClsParallelogram: ClsFourangle
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private double sideD;
        //вычисление сторон
        public void SidesCalculation()
        {
            sideA = Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
            sideB = Math.Sqrt((X2 - X3) * (X2 - X3) + (Y2 - Y3) * (Y2 - Y3));
            sideC = sideA;
            sideD = sideB;
            Console.WriteLine("Стороны ПАРАЛЛЕЛОГРАММА");
            Console.WriteLine($"Сторона A={Math.Round(sideA, 2)}");
            Console.WriteLine($"Сторона B={Math.Round(sideB, 2)}");
            Console.WriteLine($"Сторона C={Math.Round(sideC, 2)}");
            Console.WriteLine($"Сторона D={Math.Round(sideD, 2)}");
        }
        public double Perimetr()
        {
            return 2*(sideA+sideB);
        }
        public double Ploshad()
        {
            double s = 0;
            s = sideA * ((X1 - X2) * (X1 - X2) + (Y2 - Y3) * (Y2 - Y3));

            return s;
        }
    }
}
