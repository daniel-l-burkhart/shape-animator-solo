using System;
using System.Drawing;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     Holds information about a shape
    /// </summary>
    public class Shape
    {
        #region Instance variables

        /// <summary>
        ///     The new shape sprite
        /// </summary>
        private readonly ShapeSprite newShapeSprite;

        /// <summary>
        ///     The randomizer
        /// </summary>
        private readonly Random randomizer;

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

        #endregion

        #region Constructors

        /// <summary>
        ///     Default constructor
        /// </summary>
        private Shape()
        {
            this.randomizer = new Random();
            var randomShapeInstance = new RandomShape();
            this.newShapeSprite = randomShapeInstance.GetRandomShapeSprite(this);
        }

        /// <summary>
        ///     Constructs a shape at specified location
        ///     Precondition: location != null
        ///     Postcondition: X == location.X; Y == location.Y
        /// </summary>
        /// <param name="location">Location to create shape</param>
        /// <exception cref="System.ArgumentNullException">location</exception>
        public Shape(Point location) : this()
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
        public Shape(int x, int y) : this()
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
            this.X += this.randomizer.Next(-5, 6);
            this.Y += this.randomizer.Next(-5, 6);
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
            this.newShapeSprite.Paint(g);
        }

        #endregion
    }
}