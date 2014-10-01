using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
   public class Square : Shape
   {
       private ShapeSprite theSprite;
       public Square(int x, int y) : base(x, y)
       {
           theSprite = new SquareSprite(this);
       }
    }
}
