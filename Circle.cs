using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Paint
{
    class Circle : Shape
    {
        private int radius;

        public Circle(int x, int y, int size, int r, int g, int b, int radius) : base(x, y, size, r, g, b)
        {
            this.radius = radius;
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
