using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace WindowsFormsApp
{
    class Position
    {
        static public Point[] PointArr; //oint(200, 300)

        static public void Point_Init()
        {
            PointArr = new Point[78];
            PointArr[0] = new Point(0, 0);
            PointArr[1] = new Point(200, 200);
            PointArr[2] = new Point(0, 0);
        }


    }
}
