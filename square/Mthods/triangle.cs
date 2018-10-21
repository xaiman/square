using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    public class triangle : squareAll
    {
        private double sideA, sideB, sideC;

        public triangle(double sideAincom, double sideBincom, double sideCincom)
        {
            sideA = sideAincom;
            sideB = sideBincom;
            sideC = sideCincom;
        }

        public override string squareMe()
        {
            double semPer = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC)).ToString();
        }

        public override string formName()
        {
            if ((sideA * sideA + sideB * sideB == sideC * sideC) || (sideA * sideA + sideC * sideC == sideB * sideB) || (sideC * sideC + sideB * sideB == sideA * sideA))
                return "Прямоугольный треугольник";
            else if ((sideA == sideB) && (sideB == sideC))
                return "Равностронний треугольник";
            else if (((sideA == sideB) && (sideB != sideC)) || ((sideA == sideC) && (sideB != sideC)) || ((sideB == sideC) && (sideA != sideC)))
                return "Равнобедренный треугольник";
            else
                return "Треугольник";
        }

        public override bool checkFigure()
        {
            if ((sideA + sideB <= sideC) || (sideA + sideC <= sideB) || (sideB + sideC <= sideA))
                return false;
            return true;
        }

    }
}
