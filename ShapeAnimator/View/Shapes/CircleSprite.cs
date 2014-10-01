using System;
using System.Drawing;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Responsible for drawing the actual sprite on the screen.
    /// </summary>
    public class CircleSprite : ShapeSprite
    {
        #region Instance variables

        /// <summary>
        ///     The circle shape
        /// </summary>
        private readonly Shape circleShape;

        #endregion

        /// <summary>
        ///     Prevents a default instance of the <see cref="CircleSprite" /> class from being created.
        /// </summary>
        private CircleSprite()
        {
            this.circleShape = null;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CircleSprite" /> class.
        ///     Precondition: shape != null
        /// </summary>
        /// <param name="newCircle">The new circle.</param>
        /// <exception cref="System.ArgumentNullException">shape</exception>
        public CircleSprite(Shape newCircle) : this()
        {
            if (newCircle == null)
            {
                throw new ArgumentNullException("newCircle");
            }

            this.circleShape = newCircle;
        }

        /// <summary>
        ///     Draws a shape
        ///     Preconditon: g != null
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        /// <exception cref="System.ArgumentNullException">g</exception>
        public override void Paint(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }

            if (this.circleShape == null)
            {
                return;
            }

            var redBrush = new SolidBrush(Color.Red);
            g.FillEllipse(redBrush, this.circleShape.X, this.circleShape.Y, 100, 100);
        }
    }
}