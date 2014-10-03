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
    public class ShapeManager
    {
        #region Instance variables

        public const int SizeOfLargestShape = 100;

        private readonly PictureBox canvas;

        private readonly List<Shape> listOfShapes;

        private Shape newShape;

        private Random randomizer;

        #endregion

        #region Constructors

        private ShapeManager()
        {
            this.listOfShapes = new List<Shape>();
            this.newShape = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeManager" /> class.
        /// Precondition: pictureBox != null
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
            this.listOfShapes.Clear();
            this.randomizer = new Random();
            this.makeShapes(numberOfShapes);
        }

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