using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird
{
    public class Physics : Bird
    {
        public Transform transform;
        int gravity;
        int a;

        public Physics(PointF position)
        {
            transform = new Transform(position);
            gravity = 0;
            a = 1;
        }

        public void Fall()
        {
            locationY += gravity;
            gravity += a;
        }
    }
}
