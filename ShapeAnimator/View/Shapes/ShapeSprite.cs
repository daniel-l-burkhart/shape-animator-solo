using System.Drawing;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Abstract class of Shape Sprite that causes all sprite classes to implement a Paint method.
    /// </summary>
    public abstract class ShapeSprite
    {

        protected int ShapeWidth;
        public int Width
        {
            get { return ShapeWidth; }
        }
        
        
        protected int ShapeHeight;
   

        public int Height
        {
            get { return ShapeHeight; }
        }
        
        
        protected Shape AShape;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeSprite"/> class.
        /// </summary>
        protected ShapeSprite(Shape aShape, int shapeWidth, int shapeHeight)
        {
            this.ShapeWidth = shapeWidth;
            this.ShapeHeight = shapeHeight;
            this.AShape = aShape;

        }
        /// <summary>
        ///     Paints the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        public abstract void Paint(Graphics g);
    }
}