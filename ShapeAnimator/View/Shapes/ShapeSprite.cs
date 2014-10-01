using System.Drawing;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Abstract class of Shape Sprite that causes all sprite classes to implement a Paint method.
    /// </summary>
    public abstract class ShapeSprite
    {
        /// <summary>
        ///     Paints the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        public abstract void Paint(Graphics g);
    }
}