using System.Drawing;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     The square shape of the program. Derived from the Shape class
    /// </summary>
    public class Square : Shape
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Square" /> class.
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        public Square(int x, int y) : base(x, y)
        {
            this.SetDirection = TheDirections.Horizontal;
            this.ShapeSpriteInstance = new SquareSprite(this);
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Square" /> class.
        /// </summary>
        /// <param name="location">Location to create shape</param>
        public Square(Point location) : base(location)
        {
            this.SetDirection = TheDirections.Horizontal;
            this.ShapeSpriteInstance = new SquareSprite(this);
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