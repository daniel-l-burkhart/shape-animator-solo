using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    /// The Spotted Circle class that creates a new spotted circle.
    /// </summary>
    public class SpottedCircle : Shape
    {
        private ShapeSprite theSprite;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpottedCircle"/> class.
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        public SpottedCircle(int x, int y) : base(x, y)
        {
            this.theSprite = new SpottedCircleSprite(this);
        }
    }
}