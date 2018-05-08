using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.OCP.Graphic
{
    public class GraphicEditor
    {
        public void DrawShape(Shape s)
        {
            s.Draw();
        }
    }

    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            // draw the rectangle
        }
    }
}
