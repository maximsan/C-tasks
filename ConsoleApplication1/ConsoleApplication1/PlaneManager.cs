using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exam
{
    class PlaneManager
    {
        static Random random = new Random();
        //true - продолжить проведение теста
        //false - завершить проведение теста
        private bool manageResult;
        private ConsoleKeyInfo key;
        private Plane aeroplan;
        private int sumOfPoints;
        protected List<Dispatcher> dispatchers;
        public delegate bool AeroPlanChangeValue(ConsoleKeyInfo key);
        public event AeroPlanChangeValue KeyIsPush;
        public PlaneManager()
        {
            manageResult = true;
            sumOfPoints = 0;
            key = new ConsoleKeyInfo();
            aeroplan = new Plane();
            dispatchers = new List<Dispatcher>();
            AeroPlanChangeValue aeroplanchange = new AeroPlanChangeValue(aeroplan.changeValues);
            KeyIsPush += aeroplanchange;
        }
        public void addDispetcher()
        {
            string name;
            int weatherCorrect;
            Console.Write("Введите имя диспетчера: ");
            name = Console.ReadLine();
            weatherCorrect = random.Next(-200, 200);
            Dispatcher dispatcher = new Dispatcher(name, weatherCorrect);
            aeroplan.valuesWereChanged += dispatcher.trackingOfAeroplan;
            dispatchers.Add(dispatcher);
        }
        public void removeDispatcher()
        {
            if (dispatchers.Count > 0)
            {
                int index = 0;
                Console.Clear();
                Console.WriteLine("Текущее количество диспетчеров - {0}", dispatchers.Count);
                foreach (Dispatcher disp in dispatchers)
                {
                    Console.WriteLine(++index + " - " + disp);
                }
                do
                {
                    Console.WriteLine("Введите индекс удаляемого диспетчера: ");
                    index = Convert.ToInt32(Console.ReadLine()) - 1;
                } while (index < 0 || index > dispatchers.Count - 1);
                sumOfPoints += dispatchers.ElementAt(index).Points;
                aeroplan.valuesWereChanged -= dispatchers.ElementAt(index).trackingOfAeroplan;
                dispatchers.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Диспетчеров для удаления нет!");
                Thread.Sleep(1000);
            }
        }
        private void sumAllPoints()
        {
            foreach (Dispatcher disp in dispatchers)
                sumOfPoints += disp.Points;
            Console.WriteLine("Посадка завершена успешно. Штрафные баллы - {0}", sumOfPoints);
        }
        public bool manage()
        {
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.LeftArrow ||
                key.Key == ConsoleKey.RightArrow ||
                key.Key == ConsoleKey.DownArrow ||
                key.Key == ConsoleKey.UpArrow)
            {
                if (dispatchers.Count >= 2)
                {
                    manageResult = KeyIsPush(key);
                    if (!manageResult)
                        sumAllPoints();
                }
                else
                {
                    Console.WriteLine("Недостаточно диспетчеров. Добавте!");
                    Thread.Sleep(1000);
                }
            }
            else if (key.Key == ConsoleKey.Spacebar)
            {
                addDispetcher();
            }
            else if (key.Key == ConsoleKey.Delete)
            {
                removeDispatcher();
            }
            else if (key.Key == ConsoleKey.Escape)
                manageResult = false;
            return manageResult;
        }
    }
}