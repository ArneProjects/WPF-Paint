using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Paint
{
    public abstract class Shape
    {
        private int x;
        private int y;
        private int size;
        private String rgb;

        public Shape(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public int X
        {
            set { x = value; }
            get { return x; }
        }

        public int Y
        {
            set { y = value; }
            get { return y; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public abstract void Draw();
    }
}
