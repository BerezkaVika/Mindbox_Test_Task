using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHTaskLibrary
{
    public abstract class Figure
    {

        private string Name { get; set; }
        public Figure(string name)  // конструктор, устанавливающий св-во Name
        {
            Name = name;
        }

        public abstract double AreaOfFigure();

        /*	public override string ToString()
            {
                return $"Текущий тип фигуры: " + TypeName;
            }*/
    }
}