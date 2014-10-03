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

        #region Properties

        /// <summary>
        ///     The circle height
        /// </summary>
        public const int CircleCircleHeightProperty = 100;

        /// <summary>
        ///     The circle width
        /// </summary>
        public const int CircleCircleWidthProperty = 100;

        /// <summary>
        ///     Gets the CircleCircleWidthProperty.
        /// </summary>
        /// <value>
        ///     The CircleCircleWidthProperty.
        /// </value>
        public int CircleWidthProperty
        {
            get { return CircleCircleWidthProperty; }
        }

        /// <summary>
        ///     Gets the CircleHeightProperty.
        /// </summary>
        /// <value>
        ///     The CircleHeightProperty.
        /// </value>
        public int CircleHeightProperty
        {
            get { return CircleCircleHeightProperty; }
        }

        #endregion

        /// <summary>
        ///     Prevents a default instance of the <see cref="CircleSprite" /> class from being created.
        /// </summary>
        /// <summary>
        ///     Initializes a new instance of the <see cref="CircleSprite" /> class.
        ///     Precondition: shape != null
        /// </summary>
        /// <param name="newCircle">The new circle.</param>
        /// <exception cref="System.ArgumentNullException">shape</exception>
        public CircleSprite(Shape newCircle) : base(newCircle, CircleCircleWidthProperty, CircleCircleHeightProperty)
        {
            if (newCircle == null)
            {
                throw new ArgumentNullException("newCircle");
            }

            this.AShape = newCircle;
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

            if (this.AShape == null)
            {
                return;
            }
            var redBrush = new SolidBrush(Color.Red);
            g.FillEllipse(redBrush, this.AShape.X, this.AShape.Y, 100, 100);
        }
    }
}