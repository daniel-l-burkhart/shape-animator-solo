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

        /// <summary>
        /// The square shape
        /// </summary>
        private readonly Shape squareShape;

        #endregion

        /// <summary>
        /// Prevents a default instance of the <see cref="SquareSprite" /> class from being created.
        /// </summary>
        private SquareSprite()
        {
            this.squareShape = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SquareSprite" /> class.
        /// Precondition: newSquare != null
        /// </summary>
        /// <param name="newSquare">The new square.</param>
        /// <exception cref="System.ArgumentNullException">shape</exception>
        public SquareSprite(Shape newSquare) : this()
        {
            if (newSquare == null)
            {
                throw new ArgumentNullException("newSquare");
            }

            this.squareShape = newSquare;
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

            if (this.squareShape == null)
            {
                return;
            }

            var aquamarineBrush = new SolidBrush(Color.Aquamarine);
            g.FillRectangle(aquamarineBrush, this.squareShape.X, this.squareShape.Y, 50, 50);
        }
    }
}