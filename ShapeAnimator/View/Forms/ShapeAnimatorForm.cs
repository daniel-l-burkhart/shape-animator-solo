using System;
using System.Drawing;
using System.Windows.Forms;
using ShapeAnimator.Model;
using ShapeAnimator.Properties;

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
        private readonly ShapeManager shapeManager;

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
                int number = 0;
                try
                {
                    number = Convert.ToInt32(this.numberShapesTextBox.Text);
                    if (number < 0)
                    {
                        MessageBox.Show(Resources.ShapeAnimatorForm_NumberShapes_Number_of_Shapes_cannot_be_negative);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(Resources.ShapeAnimatorForm_NumberShapes_Type_must_be_of_integer_form);
                }
                return number;
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

            this.shapeManager = new ShapeManager(this.canvasPictureBox);
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
            this.shapeManager.Update(g);
            this.shapeManager.KeepShapesInBoundary();
        }

        /// <summary>
        ///     Handles the Click event of the animateButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void animateButton_Click(object sender, EventArgs e)
        {
            this.animationTimer.Stop();

            this.shapeManager.PlaceShapesOnCanvas(this.NumberShapes);

            this.animationTimer.Start();
        }

        #endregion
    }
}