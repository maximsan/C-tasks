using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Dispatcher
    {
        private string name;
        private int weatherCorrect;
        private int points;
        public Dispatcher(string name, int weatherCorrect)
        {
            this.name = name;
            this.weatherCorrect = weatherCorrect;
        }
        public int Points
        {
            get { return points; }
        }
        public override string ToString()
        {
            return name;
        }
        public bool trackingOfAeroplan(int speed, int height, Plane.Mode state)
        {
            if (state == Plane.Mode.FLY && (speed == 0 || height == 0))
                throw new Exception("Самолёт разбился: скорость -  {0}, высота - {1}"/*, speed, height*/);
            if (speed > 1000)
            {
                Console.WriteLine("Превышена максимальная скорость, немедленно сбросте скорость!");
                points += 100;
            }
            int recommendedHeight = 7 * speed - weatherCorrect;
            if (Math.Abs(recommendedHeight - height) >= 300 && Math.Abs(recommendedHeight - height) < 600)
                points += 25;
            else if (Math.Abs(recommendedHeight - height) >= 600 && Math.Abs(recommendedHeight - height) <= 1000)
                points += 50;
            else if (Math.Abs(recommendedHeight - height) > 1000)
                throw new Exception("Тренировка завершина. " +
                                    "Самолёт разбился, рекомендованная высота превышает текущую на 1000 км");
            if (points >= 1000)
                throw new Exception("Непригоден к полётам, штрафные очки диспетчера {0} - {1}"/*, name, points*/);
            Console.WriteLine("Текущая скорость - {0}, текущая высота полёта - {1} " +
                "Рекомендованная высота - {2}\nДиспетчер - {3}, штрафные баллы - {4}", speed, height, recommendedHeight, name, points);
            if (state == Plane.Mode.LANDING && (speed == 0 && height > 0))
                throw new Exception("При посадке скорость равна 0 до достижения земли. Самолёт разбился!");
            if (state == Plane.Mode.LANDING && (speed == 0 && height == 0))
                return false;
            return true;
        }
    }
}