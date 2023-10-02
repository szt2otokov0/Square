using Microsoft.Maui.Controls.Internals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square.Models
{
    internal class SquareModel
    {
        private double side;

        public double Side
        {
            get => side; set
            {
                side = Math.Abs(value);
            }
        }

        public double Perimeter => side * 4;

        public double Area =>   Math.Pow(side,2);

        public override string ToString()
        {
            return "A négyzet kerülete: " + Perimeter + ", a területe: " + Area + ".";
        }

        public SquareModel()
        {
            side = 1;
        }

    }
}
