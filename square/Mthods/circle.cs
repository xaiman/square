using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    public class circle : squareAll
    {
        private double radiusA;

        public circle(double radiusIncom)
        {
            radiusA = radiusIncom;
        }

        public override string squareMe()
        {
            return (Math.PI * radiusA * radiusA).ToString();
        }

        public override string formName()
        {
            return "Круг";
        }

        public override bool checkFigure()
        {
            if (radiusA < 0)
                return false;
            return true;
        }

    }
}
