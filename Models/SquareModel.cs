using Microsoft.Maui.Controls.Internals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square.Models
{
    internal class SquareModel : INotifyPropertyChanged
    {
        private double side;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public double Side
        {
            get => side; set
            {
                side = Math.Abs(value);
                OnPropertyChanged(nameof(Side));
                OnPropertyChanged(nameof(Perimeter));
                OnPropertyChanged(nameof(Area));
                OnPropertyChanged(nameof(Result));
            }
        }

        public double Perimeter => side * 4;

        public double Area =>   Math.Pow(side,2);

        public string Result => "A négyzet kerülete: " + Perimeter + ", a területe: " + Area + ".";

        public override string ToString()
        {
            return Result;
        }

        public SquareModel()
        {
            side = 1;
        }

    }
}
