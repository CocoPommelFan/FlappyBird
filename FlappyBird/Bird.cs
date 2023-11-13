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

        Form1 form = new Form1();
        async public void getLocation()
        {

            await Task.Run(() =>
            {
                while (true)
                {
                    this.x = form.label1.Location.X;
                    this.y = form.label1.Location.Y;
                    this.x++;
                    this.y++;
                    form.label1.Location = new Point(x, y);
                }
            });

        }
        public void Fall()
        {
            while (true)
            {
                x++;
                y++;
                form.label1.Location = new Point(x, y);
            }
        }
    }
}
