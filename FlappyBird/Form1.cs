using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 0;
        int a = 1;
        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 15;
            timer1.Tick += new EventHandler(Update);
            timer1.Start();
            this.KeyDown += new KeyEventHandler(OnKeyboardPressed);
            this.Width = 500;
            this.Height = 550;
        }

        private void OnKeyboardPressed(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode.ToString())
            {
                case "Up":
                    gravity = -10;
                    break;
            }
        }

        private void Update(object sender, EventArgs e)
        {
            if (gravity < 10)
                gravity += a;

            mainBird.Location = new Point(mainBird.Location.X, mainBird.Location.Y + gravity);

            if (mainBird.Location.Y > 450 | mainBird.Location.Y < 0 )
            {
                a = 0;
                gravity = 0;
            }
            
        }
    }
}
