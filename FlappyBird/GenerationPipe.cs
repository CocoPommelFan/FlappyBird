using System;
using System.Drawing;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace FlappyBird
{
    internal class GenerationPipe 
    {
        // Мой формс имеет размеры: 778; 747, рекоменлую сделать также, твой слишком мелкий

        // можно менять настройки , добавь их к своим а и gravity
        int
              xForPipe = 700, // размер по координате х, трогать только если хотите перемещать влево и вправо -259 координата которая вылезает за поле при моем формсе
              yForPipe, // по высоте
              speedChange = 3, // скорость изменения положения
              xForPipe2 = 1200, // вторая труба выходит чуть позже, чтобы был интервал
              yForPipe2,
              count = 0;

        private void updaitePipe(object sender, EventArgs e)
            {

            Random Random = new Random();
            if (count < 1) // Если первый раз идут трубы , то генерируется, следущие разы генерироет другой алгоритм , иначе первые два раза будут одинаковыми
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
            xForPipe -= speedChange;  // за каждые 15 миллисекунд труба изменяет свое положение на 3 пикселя(spedChange)
            xForPipe2 -= speedChange;
            }
    }  
}


