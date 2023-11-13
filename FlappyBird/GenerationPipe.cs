using System;
using System.Drawing;
using System.Threading.Tasks;

namespace FlappyBird
{
    internal class GenerationPipe
    {
        public async void AllPipe() 
        {
            Random Random = new Random();

            int
                xForPipe = 700, // размер по координате х, трогать только если хотите перемещать влево и вправо -259 координата которая вылезает за поле при моем формсе
                yForPipe = Random.Next(-450, 0), // по высоте
                spedChange = 3, // скорость изменения положения
                timeChange = 10, // интревал между обновлениями
                xForPipe2 = 1200, // вторая труба выходит чуть позже, чтобы был интервал
                yForPipe2 = Random.Next(-450, 0);

            while (true) // цикл генерации труб
            {
                Pipe.Visible = true;
                Pipe2.Visible = true;
                Pipe.Location = new Point(xForPipe, yForPipe); // Pipe это труба , если хотите поменять картинку трубы , то называйте ее также
                Pipe2.Location = new Point(xForPipe2, yForPipe2); // Вторая труба и ее локация
                xForPipe -= spedChange;  // за каждые 10 миллисекунд(timeChange) труба изменяет свое положение на 3 пикселя(spedChange)
                xForPipe2 -= spedChange;


                if (xForPipe < -300) // если труба выходит за пределы поля она переставляется немного за поле справа и генерируется высота
                {
                    xForPipe = 700;
                    yForPipe = Random.Next(-450, 0);
                }

                if (xForPipe2 < -300) // тоже самое только со второй трубой
                {
                    xForPipe2 = 700;
                    yForPipe2 = Random.Next(-450, 0);
                }

                await Task.Delay(timeChange); // делает паузу на сколько-то миллисекунд
            }
        }
    }
}
