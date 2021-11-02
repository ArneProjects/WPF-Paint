using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Paint
{
    class Pen : IThickness, IColor
    {
        private int x;
        private int y;

        public Pen(int x, int y, int size, int r, int g, int b)
        {
            this.x = x;
            this.y = y;
            Size = size;
            R = r;
            G = g;
            B = b;
        }

        public int Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int R { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int G { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int B { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
