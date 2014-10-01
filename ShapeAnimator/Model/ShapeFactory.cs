using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{

    public static class ShapeFactory
    {
        public enum myShapes
        {
            circle,
            square,
            spottedCircle
        };

        private static readonly Random randomizer = new Random();

        private static Array values = Enum.GetValues(typeof (myShapes));
        private static myShapes shape;

        public static Shape determineRandomShape()
        {
            
            Shape theShape = null;
            switch (shape)
            {
                case myShapes.circle:
                    theShape = new Circle();
                    break;
                case myShapes.square:
                    theShape = new Square();
                    break;
                case myShapes.spottedCircle:
                    theShape = new SpottedCircle();
                    break;

            }
            return theShape;
        }
    }
}
