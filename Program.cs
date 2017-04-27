using FactoryTraining.Factories;
using FactoryTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTraining
{
    class Program
    {
        public static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape shape1 = shapeFactory.getShape("CIRCLE");
            shape1.Draw();

            IShape shape2 = shapeFactory.getShape("RECTANGLE");
            shape2.Draw();

            IShape shape3 = shapeFactory.getShape("SQUARE");
            shape3.Draw();
        }
    }
}
