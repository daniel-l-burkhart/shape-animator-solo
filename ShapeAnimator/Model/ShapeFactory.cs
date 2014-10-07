using System;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     Creates a returns a Shape
    /// </summary>
    public static class ShapeFactory
    {
        #region Instance Variables

        private static MyShapes theShape;

        /// <summary>
        ///     the shape enumeration.
        /// </summary>
        private enum MyShapes
        {
            /// <summary>
            ///     The circle
            /// </summary>
            Circle,

            /// <summary>
            ///     The square
            /// </summary>
            Square,

            /// <summary>
            ///     The spotted circle
            /// </summary>
            SpottedCircle
        };

        #endregion

        #region Methods

        /// <summary>
        ///     Creates a random shape and is the purpose of the ShapeFactory.
        /// </summary>
        /// <returns></returns>
        public static Shape CreateAShape(int x, int y)
        {
            return determineRandomShape(x, y);
        }

        private static Shape determineRandomShape(int x, int y)
        {
            Shape randomShape = null;
            Array values = Enum.GetValues(typeof (MyShapes));

            theShape = (MyShapes) values.GetValue(RandomizerFactory.RandomVariable.Next(0, values.Length));

            switch (theShape)
            {
                case MyShapes.Circle:
                    randomShape = new Circle(x, y);
                    break;
                case MyShapes.Square:
                    randomShape = new Square(x, y);
                    break;
                case MyShapes.SpottedCircle:
                    randomShape = new SpottedCircle(x, y);
                    break;
            }
            return randomShape;
        }

        #endregion
    }
}