using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceImportTest
{
    class Point
    {
        private double x = 0.0;
        private double y = 0.0;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return this.X; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.Y; }
            set { this.y = value; }
        }

    }
}
