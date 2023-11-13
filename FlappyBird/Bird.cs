using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public class Bird
    {
        private int x {  get; set; }
        private int y { get; set; }
        
        float speed = 0;
        public float GetMoveSpeed(float t)
        {
            while (speed < 9)
            {
                speed = (float)(2 * t + (2 * Math.Pow(t, 2) / 2));
                return speed;
            }
            return speed;
        }
        public float GetJumpSpeed(float t)
        {
            while (speed < 10)
            {
                speed = (float)(2 * t - (Math.Pow(t, 2) / 2));
                return speed;
            }
            return speed;
        }
    }
}
