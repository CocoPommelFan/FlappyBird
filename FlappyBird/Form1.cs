using System;
using System.Drawing;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer1; // не работает без этого

        int
              xForPipe = 700, // размер по координате х, трогать только если хотите перемещать влево и вправо -259 координата которая вылезает за поле при моем формсе
              yForPipe, // по высоте
              speedChange = 3, // скорость изменения положения
              xForPipe2 = 1200, // вторая труба выходит чуть позже, чтобы был интервал
              yForPipe2,
              count = 0;

        public Form1()
        {
            InitializeComponent();
            Pipe.Visible = true;
            Pipe2.Visible = true;

            timer1 = new System.Timers.Timer(); // создание экземпляра таймера System.Timers.Timer
            timer1.Interval = 15;
            timer1.Elapsed += new ElapsedEventHandler(updaitePipe); // изменение события Tick на Elapsed
            timer1.Start();

        }

        private void updaitePipe(object sender, EventArgs e)
        {
            
            Random Random = new Random();
            if (count < 1)
            {
                count++;
                yForPipe = Random.Next(-400, -20);
                yForPipe2 = Random.Next(-400, -20);
            }

            if (xForPipe < -300) // если труба выходит за пределы поля она переставляется немного за поле справа и генерируется высота
            {
                xForPipe = 700;
                yForPipe = Random.Next(-400, -20);
            }

            if (xForPipe2 < -300) // тоже самое только со второй трубой
            {
                xForPipe2 = 700;
                yForPipe2 = Random.Next(-400, -20);
            }

            Pipe.Location = new Point(xForPipe, yForPipe); // Pipe это труба , если хотите поменять картинку трубы , то называйте ее также
            Pipe2.Location = new Point(xForPipe2, yForPipe2); // Вторая труба и ее локация
            xForPipe -= speedChange;  // за каждые 10 миллисекунд(timeChange) труба изменяет свое положение на 3 пикселя(spedChange)
            xForPipe2 -= speedChange;
        }


       

        private void Pipe_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
