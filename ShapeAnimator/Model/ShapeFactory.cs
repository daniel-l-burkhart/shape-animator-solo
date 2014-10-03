﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{

    /// <summary>
    /// Creates a returns a Shape
    /// </summary>
    public static class ShapeFactory
    {
        /// <summary>
        /// the shape enumeration.
        /// </summary>
        public enum MyShapes
        {
            /// <summary>
            /// The circle
            /// </summary>
            Circle,
            /// <summary>
            /// The square
            /// </summary>
            Square,
            /// <summary>
            /// The spotted circle
            /// </summary>
            SpottedCircle
        };

        private static MyShapes theShape;


        /// <summary>
        /// Creates a random shape and is the purpose of the ShapeFactory.
        /// </summary>
        /// <returns></returns>
        public static Shape CreateAShape()
        {
            return determineRandomShape();
        }

        private static Shape determineRandomShape()
        {
            Shape randomShape = null;
            Array values = Enum.GetValues(typeof (MyShapes));
            theShape = (MyShapes) values.GetValue(RandomizerFactory.MakeRandomizer().Next(values.Length));
                 
            switch (theShape)
            {
                case MyShapes.Circle:
                    randomShape = new Circle();
                    break;
                case MyShapes.Square:
                    randomShape = new Square();
                    break;
                case MyShapes.SpottedCircle:
                    randomShape = new SpottedCircle();
                    break;

            }
            return randomShape;
        }
    }
}
