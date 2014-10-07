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
        #region Properties

        private readonly int shapeHeight;
        private readonly int shapeWidth;
        private Shape aShape;
        private int speed = RandomizerFactory.MakeRandomizer().Next(1, 6);

        /// <summary>
        ///     Gets the get shape.
        /// </summary>
        /// <value>
        ///     The get shape.
        /// </value>
        public Shape getShape
        {
            get { return this.aShape; }
        }

        /// <summary>
        ///     Allows derived classes to set the shape.
        /// </summary>
        /// <value>
        ///     The set shape.
        /// </value>
        protected Shape SetShape
        {
            set { this.aShape = value; }
        }

        /// <summary>
        ///     Gets the width.
        /// </summary>
        /// <value>
        ///     The width.
        /// </value>
        public int Width
        {
            get { return this.shapeWidth; }
        }

        /// <summary>
        ///     Gets the height.
        /// </summary>
        /// <value>
        ///     The height.
        /// </value>
        public int Height
        {
            get { return this.shapeHeight; }
        }

        /// <summary>
        ///     Gets the speed of the Sprite.
        /// </summary>
        /// <value>
        ///     The speed.
        /// </value>
        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        #endregion

        #region Constructor

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShapeSprite" /> class.
        /// </summary>
        protected ShapeSprite(Shape aShape, int widthFromDerivedShape, int heightFromDerivedShape)
        {
            this.shapeWidth = widthFromDerivedShape;
            this.shapeHeight = heightFromDerivedShape;
            this.aShape = aShape;
        }

        #endregion

        #region Methods

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

            if (this.aShape == null)
            {
                return;
            }

            Array values = Enum.GetValues(typeof (KnownColor));
            var randomColor = (KnownColor) values.GetValue(RandomizerFactory.MakeRandomizer().Next(values.Length));
            var brush = new SolidBrush(Color.FromKnownColor(randomColor));
            g.FillEllipse(brush, this.aShape.X, this.aShape.Y, this.aShape.Width, this.aShape.Height);
        }

        #endregion
    }
}