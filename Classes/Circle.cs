using FactoryTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTraining.Classes
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle");
            Console.ReadLine();
        }
    }
}
