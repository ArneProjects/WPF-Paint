using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Paint
{
    class Triangle : Shape
    {
        private int angle1;
        private int angle2;
        private int edge1;
        private int edge2;

        public Triangle(int x, int y, int size, int r, int g, int b, int angle1, int angle2, int edge1, int edge2) : base(x, y, size, r, g, b)
        {
            this.angle1 = angle1;
            this.angle2 = angle2;
            this.edge1 = edge1;
            this.edge2 = edge2;
        }

        public int Angle1
        {
            set { angle1 = value; }
            get { return angle1; }
        }

        public int Angle2
        {
            set { angle2 = value; }
            get { return angle2; }
        }

        public int Edge1
        {
            set { edge1 = value; }
            get { return edge1; }
        }

        public int Edge2
        {
            set { edge2 = value; }
            get { return edge2; }
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
