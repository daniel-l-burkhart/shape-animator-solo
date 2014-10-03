using System.Drawing;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    /// The Spotted Circle class that creates a new spotted circle.
    /// </summary>
    public class SpottedCircle : Shape
    {
        private const int SpottedCircleWidth = 20;

        /// <summary>
        /// Gets the SpottedCircleWidth.
        /// </summary>
        /// <value>
        /// The SpottedCircleWidth.
        /// </value>
        public int Width
        {
            get { return SpottedCircleWidth; }
        }

        private const int SpottedCircleHeight = 20;

        /// <summary>
        /// Gets the CircleHeightProperty.
        /// </summary>
        /// <value>
        /// The CircleHeightProperty.
        /// </value>
        public int Height
        {
            get { return SpottedCircleHeight; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpottedCircle"/> class.
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        public SpottedCircle(int x, int y) : base(x, y)
        {
            this.ShapeSpriteInstance = new SpottedCircleSprite(this);
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SpottedCircle"/> class.
        /// </summary>
        /// <param name="location">Location to create shape</param>
        public SpottedCircle(Point location) : base(location)
        {
            this.ShapeSpriteInstance = new SpottedCircleSprite(this);
        }
    }
}