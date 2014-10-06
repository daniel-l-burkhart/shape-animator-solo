using System;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    /// </summary>
    public class SquareSprite : ShapeSprite
    {
        #region Instance variables

        #endregion

        #region Properties

        /// <summary>
        ///     The square height
        /// </summary>
        public const int SquareHeightConst = 100;

        /// <summary>
        ///     The square width
        /// </summary>
        public const int SquareWidthConst = 100;

        /// <summary>
        ///     Gets the CircleCircleWidthProperty.
        /// </summary>
        /// <value>
        ///     The CircleCircleWidthProperty.
        /// </value>
        public int SquareWidth
        {
            get { return SquareWidthConst; }
        }

        /// <summary>
        ///     Gets the CircleHeightProperty.
        /// </summary>
        /// <value>
        ///     The CircleHeightProperty.
        /// </value>
        public int SquareHeight
        {
            get { return SquareHeightConst; }
        }

        #endregion

        /// <summary>
        ///     Prevents a default instance of the <see cref="SquareSprite" /> class from being created.
        /// </summary>
        /// <summary>
        ///     Initializes a new instance of the <see cref="SquareSprite" /> class.
        ///     Precondition: newSquare != null
        /// </summary>
        /// <param name="newSquare">The new square.</param>
        /// <exception cref="System.ArgumentNullException">shape</exception>
        public SquareSprite(Shape newSquare) : base(newSquare, SquareWidthConst, SquareHeightConst)
        {
            if (newSquare == null)
            {
                throw new ArgumentNullException("newSquare");
            }

            this.AShape = newSquare;
        }
    }
}