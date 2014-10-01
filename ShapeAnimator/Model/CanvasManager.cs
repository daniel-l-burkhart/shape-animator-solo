using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ShapeAnimator.Properties;

namespace ShapeAnimator.Model
{
    /// <summary>
    /// Manages the collection of shapes on the canvas.
    /// </summary>
    public class CanvasManager
    {
        #region Instance variables

        /// <summary>
        /// The size of largest shape
        /// </summary>
        public const int SizeOfLargestShape = 100;

        /// <summary>
        /// The canvas
        /// </summary>
        private readonly PictureBox canvas;

        /// <summary>
        /// The list of shapes
        /// </summary>
        private readonly List<Shape> listOfShapes;

        /// <summary>
        /// The new shape
        /// </summary>
        private Shape newShape;

        /// <summary>
        /// The randomizer
        /// </summary>
        private Random randomizer;

        #endregion

        #region Constructors

        /// <summary>
        /// Prevents a default instance of the <see cref="CanvasManager" /> class from being created.
        /// </summary>
        private CanvasManager()
        {
            this.listOfShapes = new List<Shape>();
            this.newShape = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CanvasManager" /> class.
        /// Precondition: pictureBox != null
        /// </summary>
        /// <param name="pictureBox">The picture box that the program will be drawing on</param>
        /// <exception cref="System.ArgumentNullException">pictureBox</exception>
        public CanvasManager(PictureBox pictureBox) : this()
        {
            if (pictureBox == null)
            {
                throw new ArgumentNullException("pictureBox", Resources.PictureBoxNullMessage);
            }
            this.canvas = pictureBox;
        }

        #endregion

        /// <summary>
        /// Places the shape on the canvas.
        /// Precondition: numberOfShapes != less than 0
        /// </summary>
        /// <param name="numberOfShapes">The number of shapes.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Number of shapes cannot be negative.</exception>
        /// <exception cref="System.ArgumentNullException">number of shapes cannot be null.</exception>
        public void PlaceShapesOnCanvas(int numberOfShapes)
        {
            if (numberOfShapes < 0)
            {
                throw new ArgumentOutOfRangeException("numberOfShapes");
            }
            this.randomizer = new Random();
            this.makeShapes(numberOfShapes);
        }

        /// <summary>
        /// Makes the shapes.
        /// </summary>
        /// <param name="numberOfShapes">The number of shapes.</param>
        private void makeShapes(int numberOfShapes)
        {
            for (int i = 0; i < numberOfShapes; i++)
            {
                int x = this.randomizer.Next(0, this.canvas.Width - SizeOfLargestShape);
                int y = this.randomizer.Next(0, this.canvas.Height - SizeOfLargestShape);
                this.newShape = new Shape(x, y);
                this.listOfShapes.Add(this.newShape);
            }
        }

        /// <summary>
        /// Moves the shape around and the calls the Shape::Paint method to draw the shape.
        /// Precondition: g != null
        /// </summary>
        /// <param name="g">The graphics object to draw on</param>
        /// <exception cref="System.ArgumentNullException">g</exception>
        public void Update(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }

            foreach (Shape currentShape in this.listOfShapes)
            {
                if (currentShape == null)
                {
                    return;
                }
                currentShape.Move();
                currentShape.Paint(g);
            }
        }
    }
}