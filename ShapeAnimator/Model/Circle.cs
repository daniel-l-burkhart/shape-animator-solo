using System.Drawing;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     The cirlce class that is derived from the Shape class.
    /// </summary>
    public class Circle : Shape
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Circle" /> class.
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        public Circle(int x, int y) : base(x, y)
        {
            this.SetDirection = TheDirections.Vertical;
            this.ShapeSpriteInstance = new CircleSprite(this);
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Circle" /> class.
        /// </summary>
        /// <param name="location">Location to create shape</param>
        public Circle(Point location) : base(location)
        {
            this.SetDirection = TheDirections.Vertical;
            this.ShapeSpriteInstance = new CircleSprite(this);
        }

        /// <summary>
        ///     Draws a shape
        ///     Precondition: g != NULL
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        /// <exception cref="System.ArgumentNullException">g</exception>
        public override void Paint(Graphics g)
        {
            this.SetDirection = TheDirections.Vertical;
            this.ShapeSpriteInstance.Paint(g);
        }

        #endregion
    }
}