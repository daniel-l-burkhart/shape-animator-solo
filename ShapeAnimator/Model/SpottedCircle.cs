using System.Drawing;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     The Spotted Circle class that creates a new spotted circle.
    /// </summary>
    public class SpottedCircle : Shape
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SpottedCircle" /> class.
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        public SpottedCircle(int x, int y) : base(x, y)
        {
            this.SetDirection = TheDirections.Vertical;
            this.ShapeSpriteInstance = new SpottedCircleSprite(this);
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SpottedCircle" /> class.
        /// </summary>
        /// <param name="location">Location to create shape</param>
        public SpottedCircle(Point location) : base(location)
        {
            this.SetDirection = TheDirections.Vertical;
            this.ShapeSpriteInstance = new SpottedCircleSprite(this);
        }

        /// <summary>
        ///     Draws a shape
        ///     Precondition: g != NULL
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        /// <exception cref="System.ArgumentNullException">g</exception>
        public override void Paint(Graphics g)
        {
            this.ShapeSpriteInstance.Paint(g);
        }

        #endregion
    }
}