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
        public const int CircleCircleHeightPropertyConst = 100;

        /// <summary>
        ///     The circle width
        /// </summary>
        public const int CircleCircleWidthPropertyConst = 100;

        /// <summary>
        ///     Gets the CircleCircleWidthProperty.
        /// </summary>
        /// <value>
        ///     The CircleCircleWidthProperty.
        /// </value>
        public int CircleWidthProperty
        {
            get { return CircleCircleWidthPropertyConst; }
        }

        /// <summary>
        ///     Gets the CircleHeightProperty.
        /// </summary>
        /// <value>
        ///     The CircleHeightProperty.
        /// </value>
        public int CircleHeightProperty
        {
            get { return CircleCircleHeightPropertyConst; }
        }

        #endregion

        #region Constructor

        /// <summary>
        ///     Initializes a new instance of the <see cref="CircleSprite" /> class.
        ///     Precondition: shape != null
        /// </summary>
        /// <param name="newCircle">The new circle.</param>
        /// <exception cref="System.ArgumentNullException">shape</exception>
        public CircleSprite(Shape newCircle)
            : base(newCircle, CircleCircleWidthPropertyConst, CircleCircleHeightPropertyConst)
        {
            if (newCircle == null)
            {
                throw new ArgumentNullException("newCircle");
            }

            this.SetShape = newCircle;
        }

        #endregion

        #region Method

        /// <summary>
        ///     Paints the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        public override void Paint(Graphics g)
        {
            base.Paint(g);
            var brush = new SolidBrush(Color.FromKnownColor(this.GetRandomColor));

            g.FillEllipse(brush, this.AShape.X, this.AShape.Y, this.CircleWidthProperty, this.CircleHeightProperty);
        }

        #endregion
    }
}