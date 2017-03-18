using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PlaneManager aeroplanManager = new PlaneManager();
                do
                {
                    Console.Clear();
                    Console.WriteLine("Управление самолётом:\n\"Стрелка вправо\" - увеличение скорости на 50 км/ч\n" +
                          "\"Стрелка вправо + SHIFT\"- увеличение скорости на 150 км/ч\n" +
                          "\"Стрелка влево\"- уменьшение скорости на 50 км/ч\n" +
                          "\"Стрелка влево + SHIFT\"- уменьшение скорости на 150 км/ч\n" +
                          "\"Стрелка вверх\" - увеличение высоты на 250 км\n" +
                          "\"Стрелка вверх + SHIFT\"- увеличение высоты на 500 км\n" +
                          "\"Стрелка вниз\"- уменьшение высоты на 250 км\n" +
                          "\"Стрелка вниз + SHIFT\"- уменьшение высоты на 500 км\n" +
                          "SpaceBar - добавить диспетчера\nDelete - удалить диспетчера\nEsc - выход из программы");
                } while (aeroplanManager.manage());
                Console.WriteLine("Программа завершена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Программа завершена");
            }
        }
    }
}