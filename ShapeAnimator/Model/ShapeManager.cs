using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ShapeAnimator.Properties;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     Manages the collection of shapes on the canvas.
    /// </summary>
    public class ShapeManager
    {
        #region Instance variables

        private readonly PictureBox canvas;

        private readonly List<Shape> shapes;

        private Shape newShape;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the width of the canvas.
        /// </summary>
        /// <value>
        ///     The width of the canvas.
        /// </value>
        public int CanvasWidth
        {
            get { return this.canvas.Width; }
        }

        /// <summary>
        ///     Gets the height of the canvas.
        /// </summary>
        /// <value>
        ///     The height of the canvas.
        /// </value>
        public int CanvasHeight
        {
            get { return this.canvas.Height; }
        }

        #endregion

        #region Constructors

        private ShapeManager()
        {
            this.shapes = new List<Shape>();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShapeManager" /> class.
        ///     Precondition: pictureBox != null
        /// </summary>
        /// <param name="pictureBox">The picture box that the program will be drawing on</param>
        /// <exception cref="System.ArgumentNullException">pictureBox</exception>
        public ShapeManager(PictureBox pictureBox) : this()
        {
            if (pictureBox == null)
            {
                throw new ArgumentNullException("pictureBox", Resources.PictureBoxNullMessage);
            }
            this.canvas = pictureBox;
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Places the shape on the canvas.
        ///     Precondition: numberOfShapes != less than 0
        /// </summary>
        /// <param name="numberOfShapes">The number of shapes.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Number of shapes cannot be negative.</exception>
        /// <exception cref="System.ArgumentNullException">number of shapes cannot be null.</exception>
        public void PlaceShapesOnCanvas(int numberOfShapes)
        {
            this.shapes.Clear();
            this.makeShapes(numberOfShapes);
        }

        private void makeShapes(int numberOfShapes)
        {
            for (int i = 0; i < numberOfShapes; i++)
            {
                this.newShape = ShapeFactory.CreateAShape(0, 0);

                this.newShape.X = RandomizerFactory.RandomVariable.Next(0, this.CanvasWidth - this.newShape.Width);
                this.newShape.Y = RandomizerFactory.RandomVariable.Next(0, this.CanvasHeight - this.newShape.Height);

                this.shapes.Add(this.newShape);
            }
        }

        /// <summary>
        ///     Keeps the shapes in boundary.
        /// </summary>
        public void KeepShapesInBoundary()
        {
            foreach (Shape randomShape in this.shapes)
            {
                this.putShapesInBoundary(randomShape);
            }
        }

        private void putShapesInBoundary(Shape thisShape)
        {
            if (thisShape.GetDirection.Equals(Shape.TheDirections.Horizontal))
            {
                this.bounceOffHorizontally(thisShape);
            }

            if (thisShape.GetDirection.Equals(Shape.TheDirections.Vertical))
            {
                this.bounceOffVeritically(thisShape);
            }
        }

        private void bounceOffVeritically(Shape verticalShape)
        {
            if (verticalShape.Y.Equals(0))
            {
                verticalShape.Speed *= -1;
            }

            if (verticalShape.Y >= (this.CanvasHeight - verticalShape.Height))
            {
                verticalShape.Speed *= -1;
            }
        }

        private void bounceOffHorizontally(Shape horizontalShape)
        {
            if (horizontalShape.X.Equals(0))
            {
                horizontalShape.Speed *= -1;
            }
            if (horizontalShape.X >= (this.CanvasWidth - horizontalShape.Width))
            {
                horizontalShape.Speed *= -1;
            }
        }

        /// <summary>
        ///     Moves the shape around and the calls the Shape::Paint method to draw the shape.
        ///     Precondition: g != null
        /// </summary>
        /// <param name="g">The graphics object to draw on</param>
        /// <exception cref="System.ArgumentNullException">g</exception>
        public void Update(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }

            foreach (Shape currentShape in this.shapes)
            {
                if (currentShape == null)
                {
                    return;
                }
                currentShape.Move();
                currentShape.Paint(g);
            }
        }

        #endregion
    }
}