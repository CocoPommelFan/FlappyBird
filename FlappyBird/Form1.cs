using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {

        public int x;
        public int y;
        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 15;
            timer1.Tick += new EventHandler(Move);
            timer1.Start();
            this.KeyPress += new KeyPressEventHandler(Jump);
        }

        Bird bird = new Bird();
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        async public new void Move(object sender, EventArgs e)
        {

            float t = 0;
            while (mainBird.Location.Y < 400)
            {
                double s = bird.GetMoveSpeed(t);

                t += 0.1f;
                mainBird.Location = new Point(mainBird.Location.X, mainBird.Location.Y + (int)s);
                label1.Text = s.ToString();
                await Task.Delay(1);
            }
        }

        //async public new void Move(object sender, EventArgs e)
        //{

        //    float t = 0;
        //    while (mainBird.Location.Y < 400)
        //    {
        //        double s = bird.GetMoveSpeed(t);

        //        t += 0.1f;
        //        mainBird.Location = new Point(mainBird.Location.X, mainBird.Location.Y + (int)s);
        //        label1.Text = s.ToString();
        //        await Task.Delay(1);
        //    }
        //}
        public void Jump(object sender, KeyPressEventArgs e)
        {

            float t = 0;
            
            if (e.KeyChar == (char)Keys.W)
            {

                double s = bird.GetJumpSpeed(t);

                t += 0.1f;
                mainBird.Location = new Point(mainBird.Location.X, mainBird.Location.Y + (int)s);
                label3.Text = s.ToString();
                    
            }
            
        }
    }
}
