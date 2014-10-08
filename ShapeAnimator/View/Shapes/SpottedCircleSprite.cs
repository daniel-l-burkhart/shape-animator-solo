using System;
using System.Drawing;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     A spotted circle class that is derived off the Circle sprite class.
    /// </summary>
    public class SpottedCircleSprite : CircleSprite
    {
        #region Instance Variables

        /// <summary>
        ///     The chang e_ factor
        /// </summary>
        public const int ChangeFactor = 20;

        private SolidBrush dotBrush;

        #endregion

        #region Constructor

        /// <summary>
        ///     Initializes a new instance of the <see cref="SpottedCircleSprite" /> class.
        /// </summary>
        /// <param name="newSpottedCircle">The new spotted circle.</param>
        /// <exception cref="System.ArgumentNullException">shape</exception>
        public SpottedCircleSprite(Shape newSpottedCircle) : base(newSpottedCircle)
        {
            if (newSpottedCircle == null)
            {
                throw new ArgumentNullException("newSpottedCircle");
            }

            this.SetShape = newSpottedCircle;
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Draws a shape
        ///     Preconditon: g != null
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        public override void Paint(Graphics g)
        {
            base.Paint(g);
            this.fillWithDots(g);
        }

        /// <summary>
        ///     Fills the with dots.
        /// </summary>
        /// <param name="g">The g.</param>
        private void fillWithDots(Graphics g)
        {
            this.dotBrush = new SolidBrush(Color.White);

            int dotX = (this.GetShapeSpriteShape.X + ChangeFactor);
            int dotY = (this.GetShapeSpriteShape.Y + ChangeFactor);

            g.FillEllipse(this.dotBrush, dotX, dotY, 20, 20);

            dotX += ChangeFactor;
            dotY += ChangeFactor;
            g.FillEllipse(this.dotBrush, dotX, dotY, 20, 20);

            dotX -= ChangeFactor;
            dotY += ChangeFactor;
            g.FillEllipse(this.dotBrush, dotX, dotY, 20, 20);
        }

        #endregion
    }
}