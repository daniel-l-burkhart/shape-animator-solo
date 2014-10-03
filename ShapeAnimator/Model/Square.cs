using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
   public class Square : Shape
   {
       public Square(int x, int y) : base(x, y)
       {
           this.newShapeSprite = new SquareSprite(this);
       }

    }
}
