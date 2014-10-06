using System;
using System.Drawing;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     Holds information about a shape
    /// </summary>
    public abstract class Shape
    {
        #region Instance variables

        /// <summary>
        ///     Enumeration between horizontal and vertical movement
        /// </summary>
        public enum TheDirections
        {
            /// <summary>
            ///     The horizontal direction
            /// </summary>
            Horizontal,

            /// <summary>
            ///     The vertical direction
            /// </summary>
            Vertical
        }

        protected TheDirections CurrentDirection;

        /// <summary>
        ///     The new shape sprite
        /// </summary>
        protected ShapeSprite ShapeSpriteInstance;

        /// <summary>
        ///     The location
        /// </summary>
        private Point location;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the x location of the shape.
        /// </summary>
        /// <value>
        ///     The x.
        /// </value>
        public int X
        {
            get { return this.location.X; }
            set { this.location.X = value; }
        }

        /// <summary>
        ///     Gets or sets the y location of the shape.
        /// </summary>
        /// <value>
        ///     The y.
        /// </value>
        public int Y
        {
            get { return this.location.Y; }
            set { this.location.Y = value; }
        }

        /// <summary>
        ///     Gets the CircleWidthProperty.
        /// </summary>
        /// <value>
        ///     The CircleWidthProperty.
        /// </value>
        public int Width
        {
            get { return this.ShapeSpriteInstance.Width; }
        }

        /// <summary>
        ///     Gets the CircleHeightProperty.
        /// </summary>
        /// <value>
        ///     The CircleHeightProperty.
        /// </value>
        public int Height
        {
            get { return this.ShapeSpriteInstance.Height; }
        }

        /// <summary>
        ///     Gets the speed.
        /// </summary>
        /// <value>
        ///     The speed.
        /// </value>
        public int Speed
        {
            get { return this.ShapeSpriteInstance.Speed; }
        }

        #endregion

        #region Constructors

        /// <summary>
        ///     Default constructor
        /// </summary>
        private Shape()
        {
        }

        /// <summary>
        ///     Constructs a shape at specified location
        ///     Precondition: location != null
        ///     Postcondition: X == location.X; Y == location.Y
        /// </summary>
        /// <param name="location">Location to create shape</param>
        /// <exception cref="System.ArgumentNullException">location</exception>
        protected Shape(Point location) : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.location = location;
        }

        /// <summary>
        ///     Constructs a shape specified x,y location
        ///     Precondition: None
        ///     Postcondition: X == x; Y == y
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        protected Shape(int x, int y) : this()
        {
            this.location = new Point(x, y);
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Randomly moves a shape in the x, y direction
        ///     Precondition: None
        ///     Postcondition: X == X@prev + amount of movement in X direction; Y == Y@prev + amount of movement in Y direction
        /// </summary>
        public void Move()
        {
            switch (this.CurrentDirection)
            {
                case TheDirections.Horizontal:
                    this.X += this.Speed;
                    break;
                case TheDirections.Vertical:
                    this.Y += this.Speed;
                    break;
            }
        }

        /// <summary>
        ///     Draws a shape
        ///     Precondition: g != NULL
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        /// <exception cref="System.ArgumentNullException">g</exception>
        public void Paint(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }
            this.ShapeSpriteInstance.Paint(g);
        }

        #endregion
    }
}