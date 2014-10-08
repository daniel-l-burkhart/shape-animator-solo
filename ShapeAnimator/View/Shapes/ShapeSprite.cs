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

        private readonly KnownColor randomColor;
        private readonly int shapeHeight;
        private readonly int shapeWidth;
        protected Shape MyShapeSpriteShape;
        private int speed = RandomizerFactory.RandomVariable.Next(1, 6);

        /// <summary>
        ///     Gets the get shape.
        /// </summary>
        /// <value>
        ///     The get shape.
        /// </value>
        public Shape GetShapeSpriteShape
        {
            get { return this.MyShapeSpriteShape; }
        }

        /// <summary>
        ///     Allows derived classes to set the shape.
        /// </summary>
        /// <value>
        ///     The set shape.
        /// </value>
        protected Shape SetShape
        {
            set { this.MyShapeSpriteShape = value; }
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

        /// <summary>
        ///     Gets the random color.
        /// </summary>
        /// <value>
        ///     The random color of the get.
        /// </value>
        public KnownColor GetRandomColor
        {
            get { return this.randomColor; }
        }

        #endregion

        #region Constructor

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShapeSprite" /> class.
        /// </summary>
        protected ShapeSprite(Shape derivedShapeSpriteShape, int widthFromDerivedShape, int heightFromDerivedShape)
        {
            this.shapeWidth = widthFromDerivedShape;
            this.shapeHeight = heightFromDerivedShape;
            this.MyShapeSpriteShape = derivedShapeSpriteShape;

            Array values = Enum.GetValues(typeof (KnownColor));
            this.randomColor = (KnownColor) values.GetValue(RandomizerFactory.RandomVariable.Next(values.Length));
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Paints the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        public virtual void Paint(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }
        }

        #endregion
    }
}