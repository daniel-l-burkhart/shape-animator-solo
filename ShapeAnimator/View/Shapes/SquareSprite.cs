using System;
using System.Drawing;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    /// 
    /// </summary>
    public class SquareSprite : ShapeSprite
    {
        #region Instance variables

        #endregion

        #region Properties
        /// <summary>
        /// The square height
        /// </summary>
        public const int SquareHeightConst = 100;
        /// <summary>
        /// The square width
        /// </summary>
        public const int SquareWidthConst = 100;

        /// <summary>
        ///     Gets the CircleCircleWidthProperty.
        /// </summary>
        /// <value>
        ///     The CircleCircleWidthProperty.
        /// </value>
        public int SquareWidth
        {
            get { return SquareWidthConst; }
        }

        /// <summary>
        ///     Gets the CircleHeightProperty.
        /// </summary>
        /// <value>
        ///     The CircleHeightProperty.
        /// </value>
        public int SquareHeight
        {
            get { return SquareHeightConst; }
        }
        #endregion
        /// <summary>
        /// Prevents a default instance of the <see cref="SquareSprite" /> class from being created.
        /// </summary>
       

        /// <summary>
        /// Initializes a new instance of the <see cref="SquareSprite" /> class.
        /// Precondition: newSquare != null
        /// </summary>
        /// <param name="newSquare">The new square.</param>
        /// <exception cref="System.ArgumentNullException">shape</exception>
        public SquareSprite(Shape newSquare) : base(newSquare, SquareWidthConst, SquareHeightConst)
        {
            if (newSquare == null)
            {
                throw new ArgumentNullException("newSquare");
            }

            AShape = newSquare;
        }

        /// <summary>
        /// Draws a shape
        /// Preconditon: g != null squareShape != null
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        /// <exception cref="System.ArgumentNullException">g</exception>
        public override void Paint(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }

            if (AShape == null)
            {
                return;
            }

            var aquamarineBrush = new SolidBrush(Color.Aquamarine);
            g.FillRectangle(aquamarineBrush, AShape.X, AShape.Y, 50, 50);
        }
    }
}