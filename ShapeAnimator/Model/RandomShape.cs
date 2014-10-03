using System;
using System.Collections.Generic;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     Gets a random Shape.
    /// </summary>
    public class RandomShape
    {
        #region Instance Variables

        /// <summary>
        ///     The list of shape sprites
        /// </summary>
        private List<ShapeSprite> listOfShapeSprites;

        /// <summary>
        ///     The random int
        /// </summary>
        private int randomInt;

        /// <summary>
        ///     The shape sprite instance
        /// </summary>
        private ShapeSprite randomShapeSpriteInstance;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="RandomShape" /> class.
        /// </summary>
        public RandomShape()
        {
            this.randomInt = 0;
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Makes the list of shapes and returns the random ShapeSprite
        /// </summary>
        /// <param name="newShape">The shape being passed in to create the lsit</param>
        /// <returns></returns>
        public ShapeSprite GetRandomShapeSprite(Shape newShape)
        {
            this.listOfShapeSprites = new List<ShapeSprite>
            {
                new SquareSprite(newShape),
                new CircleSprite(newShape),
                new SpottedCircleSprite(newShape)
            };

            this.randomInt = RandomizerFactory.MakeRandomizer().Next(0, 3);

            this.randomShapeSpriteInstance = this.listOfShapeSprites[this.randomInt];
            return this.randomShapeSpriteInstance;
        }

        #endregion
    }
}