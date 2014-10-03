using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    /// The square shape of the program. Derived from the Shape class
    /// </summary>
   public class Square : Shape
   {

        /// <summary>
       /// Initializes a new instance of the <see cref="Square"/> class.
       /// </summary>
       /// <param name="x">The x coordinate</param>
       /// <param name="y">The y coordinate</param>
       public Square(int x, int y) : base(x, y)
       {
           this.ShapeSpriteInstance = new SquareSprite(this);
       }

       /// <summary>
       /// Initializes a new instance of the <see cref="Square"/> class.
       /// </summary>
       /// <param name="location">Location to create shape</param>
        public Square(Point location) : base(location)
        {
            this.ShapeSpriteInstance = new SquareSprite(this);
        }

    }
}
