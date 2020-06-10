using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Ado_2
{
    public class Ring
    {
        public int X { get; }
        public int Y { get; }
        public int innerRadius { get; }
        public int outherRadius { get; }
        public Ring(int x, int y, int innerRadius, int outherRadius)
        {
            this.X = x;
            this.Y = y;
            this.innerRadius = innerRadius;
            this.outherRadius = outherRadius;
        }
        public double S
        {
            get
            {
                return Math.PI * (outherRadius * outherRadius - innerRadius * innerRadius);
            }
        }
        public double Sum
        {
            get
            {
                return 2 * Math.PI * outherRadius + 2 * Math.PI * innerRadius;
            }
        }
        public void Show()
        {
            Console.WriteLine("Координаты центра: {0} {1}; Внешний радиус = {2}; Внутренний радиус = {3}", X, Y, outherRadius, innerRadius);
            Console.WriteLine("Площадь: {0}; Суммарная длина внейшней и внутренней окружности: {1}", S, Sum);
        }


    }
}
