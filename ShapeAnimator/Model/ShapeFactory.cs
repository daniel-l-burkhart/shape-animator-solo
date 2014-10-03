using System;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     Creates a returns a Shape
    /// </summary>
    public static class ShapeFactory
    {
        /// <summary>
        ///     the shape enumeration.
        /// </summary>
        public enum MyShapes
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

        private static MyShapes theShape;

        /// <summary>
        ///     Creates a random shape and is the purpose of the ShapeFactory.
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
                    randomShape = new Circle(0, 0);
                    break;
                case MyShapes.Square:
                    randomShape = new Square(0, 0);
                    break;
                case MyShapes.SpottedCircle:
                    randomShape = new SpottedCircle(0, 0);
                    break;
            }
            return randomShape;
        }
    }
}