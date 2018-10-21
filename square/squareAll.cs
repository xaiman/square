using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    public abstract class squareAll
    {
        public abstract string squareMe();
        public abstract string formName();
        public abstract bool checkFigure();

        public void finalMessage()
        {
            if (checkFigure())
                Console.WriteLine($"Фигура {formName()}.Площадь {squareMe()}");
            else
                Console.WriteLine("Не правильно заданы параметры");
        }
    }
}
