using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Paint
{
    public abstract class Shape : IThickness, IColor
    {
        private int x;
        private int y;

        public Shape(int x, int y, int size, int r, int g, int b)
        {
            this.x = x;
            this.y = y;
            R = r;
            G = g;
            B = b;
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

        public int Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int R { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int G { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int B { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public abstract void Draw();
    }
}
