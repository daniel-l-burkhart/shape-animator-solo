using System;
using System.Drawing;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Abstract class of Shape Sprite that causes all sprite classes to implement a Paint method.
    /// </summary>
    public abstract class ShapeSprite
    {
        protected Shape AShape;
        protected int ShapeHeight;
        protected int ShapeWidth;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShapeSprite" /> class.
        /// </summary>
        protected ShapeSprite(Shape aShape, int shapeWidth, int shapeHeight)
        {
            this.ShapeWidth = shapeWidth;
            this.ShapeHeight = shapeHeight;
            this.AShape = aShape;
        }

        /// <summary>
        ///     Gets the width.
        /// </summary>
        /// <value>
        ///     The width.
        /// </value>
        public int Width
        {
            get { return this.ShapeWidth; }
        }

        /// <summary>
        ///     Gets the height.
        /// </summary>
        /// <value>
        ///     The height.
        /// </value>
        public int Height
        {
            get { return this.ShapeHeight; }
        }

        /// <summary>
        ///     Gets the speed of the Sprite.
        /// </summary>
        /// <value>
        ///     The speed.
        /// </value>
        public int Speed
        {
            get { return RandomizerFactory.MakeRandomizer().Next(1, 6); }
        }

        /// <summary>
        ///     Paints the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        public void Paint(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }

            if (this.AShape == null)
            {
                return;
            }

            Array values = Enum.GetValues(typeof (KnownColor));
            var randomColor = (KnownColor) values.GetValue(RandomizerFactory.MakeRandomizer().Next(values.Length));
            var brush = new SolidBrush(Color.FromKnownColor(randomColor));
            g.FillEllipse(brush, this.AShape.X, this.AShape.Y, this.AShape.Width, this.AShape.Height);
        }
    }
}