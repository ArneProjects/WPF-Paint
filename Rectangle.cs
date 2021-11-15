using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Paint
{
    public class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int x, int y, int size, int width, int height) : base(x, y, size)
        {
            this.width = width;
            this.height = height;
        }

        public int Width
        {
            set { width = value; }
            get { return width; }
        }

        public int Height
        {
            set { height = value; }
            get { return height; }
        }
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
