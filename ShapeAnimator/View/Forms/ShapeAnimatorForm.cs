using System;
using System.Drawing;
using System.Windows.Forms;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Forms
{
    /// <summary>
    ///     Manages the form that will display shapes.
    /// </summary>
    public partial class ShapeAnimatorForm
    {
        #region Instance variables

        /// <summary>
        ///     The canvas manager
        /// </summary>
        private readonly CanvasManager canvasManager;

        #endregion

        #region Properties

        /// <summary>
        ///     Converts the text in the numberShapesTextBox to an integer. If the text
        ///     is not convertable to an integer value it returns 0.
        /// </summary>
        /// <value>
        ///     The number shapes.
        /// </value>
        public int NumberShapes
        {
            get
            {
                try
                {
                    return Convert.ToInt32(this.numberShapesTextBox.Text);
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShapeAnimatorForm" /> class.
        ///     Precondition: None
        /// </summary>
        public ShapeAnimatorForm()
        {
            this.InitializeComponent();

            this.canvasManager = new CanvasManager(this.canvasPictureBox);
        }

        #endregion

        #region Event generated methods

        /// <summary>
        ///     Handles the Tick event of the animationTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        /// <summary>
        ///     Handles the Paint event of the shapeCanvasPictureBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs" /> instance containing the event data.</param>
        private void shapeCanvasPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            this.canvasManager.Update(g);
        }

        /// <summary>
        ///     Handles the Click event of the animateButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void animateButton_Click(object sender, EventArgs e)
        {
            this.animationTimer.Stop();

            this.canvasManager.PlaceShapesOnCanvas(this.NumberShapes);

            this.animationTimer.Start();
        }

        #endregion
    }
}