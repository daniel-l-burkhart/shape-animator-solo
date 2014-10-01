using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    public class Circle : Shape
    {
        private ShapeSprite theSprite;
        public Circle(int x, int y) : base(x, y)
        {
            theSprite = new CircleSprite(this);
        }
    }
}
