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
        /// Gets the width of the canvas.
        /// </summary>
        /// <value>
        /// The width of the canvas.
        /// </value>
        public int CanvasWidth
        {
            get { return this.canvas.Width; }
        }

        /// <summary>
        /// Gets the height of the canvas.
        /// </summary>
        /// <value>
        /// The height of the canvas.
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
                this.newShape = ShapeFactory.CreateAShape();
                this.placeShapesWithinBounds();

                this.shapes.Add(this.newShape);
            }
        }

        private void placeShapesWithinBounds()
        {
            this.newShape.X -= this.newShape.Width;
            this.newShape.Y -= this.newShape.Height;
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
                currentShape.KeepInBoundary();
            }
        }
    }
}