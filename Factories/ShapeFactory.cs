using FactoryTraining.Classes;
using FactoryTraining.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTraining.Factories
{
    public class ShapeFactory
    {
        public IShape getShape(string shapeType)
        {
            switch (shapeType)
            {
                case "RECTANGLE":
                    return new Rectangle();

                case "SQUARE" :
                    return new Square();

                case "CIRCLE" :
                    return new Circle();

                default:
                    return null;
            }
        }
    }
}
