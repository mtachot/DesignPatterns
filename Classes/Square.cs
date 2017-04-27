using FactoryTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTraining.Classes
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square");
            Console.ReadLine();
        }
    }
}
