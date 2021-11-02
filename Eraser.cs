using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Paint
{
    class Eraser : IThickness
    {
        private int x;
        private int y;

        public Eraser(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            Size = size;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            set { y = value; }
            get { return y; }
        }

        public int Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
