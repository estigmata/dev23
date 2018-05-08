using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.OCPViolation.Graphic
{
    public class GraphicEditor
    {
        public void DrawShape(Shape s)
        {
            if (s.Type == 1)
            {
                DrawRectangle(s as Rectangle);
            }
            else if (s.Type == 2)
            {
                DrawCircle(s as Circle);
            }
        }

        public void DrawCircle(Circle r)
        {
            // Do something...
        }

        public void DrawRectangle(Rectangle r)
        {
            // Do something...
        }
    }

    public class Shape
    {
        public int Type { get; set; }
    }

    public class Rectangle : Shape
    {
        public Rectangle()
        {
            Type = 1;
        }
    }

    public class Circle : Shape
    {
        public Circle()
        {
            Type = 2;
        }
    }
}
