using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Plane
    {
        private int speed;
        private int height;
        public enum Mode { TAKEOFF, FLY, LANDING }
        private Mode state;
        private bool isFlyEnding;
        public delegate bool ValuesWereChanged(int speed, int height, Mode state);
        public ValuesWereChanged valuesWereChanged;
        public Plane()
        {
            this.speed = 0;
            this.height = 0;
            valuesWereChanged = null;
            state = Mode.TAKEOFF;
            isFlyEnding = false;
        }
        public int Speed
        {
            get { return speed; }
        }
        public int Height
        {
            get { return height; }
        }
        public Mode getState()
        {
            return state;
        }
        public bool changeValues(ConsoleKeyInfo key)
        {
            if (isFlyEnding)
            {
                state = Mode.LANDING;
                Console.WriteLine("ПОСАДКА!!!");
            }
            Console.Clear();
            if (key.Modifiers != ConsoleModifiers.Shift && key.Key == ConsoleKey.LeftArrow && speed > 0)
            {
                speed -= 50;
                Console.WriteLine("Скорость уменьшена на 50 км/ч");
            }
            else if (key.Modifiers == ConsoleModifiers.Shift && key.Key == ConsoleKey.LeftArrow && speed > 0)
            {
                speed -= 150;
                Console.WriteLine("Скорость уменьшена на 150 км/ч");
            }
            else if (key.Modifiers != ConsoleModifiers.Shift && key.Key == ConsoleKey.RightArrow)
            {
                speed += 50;
                if (speed >= 1000)
                {
                    isFlyEnding = true;
                    Console.WriteLine("Достигнута максимальная скорость в 1000 км/ч. Посадка");
                }
                else
                    Console.WriteLine("Скорость увеличена на 50 км/ч");
            }
            else if (key.Modifiers == ConsoleModifiers.Shift && key.Key == ConsoleKey.RightArrow)
            {
                speed += 150;
                if (speed > 1000)
                {
                    isFlyEnding = true;
                    Console.WriteLine("Достигнута максимальная скорость в 1000 км/ч. Посадка");
                }
                else
                    Console.WriteLine("Скорость увеличена на 150 км/ч");
            }
            else if (key.Modifiers != ConsoleModifiers.Shift && key.Key == ConsoleKey.DownArrow && height > 0)
            {
                height -= 250;
                Console.WriteLine("Высота уменьшена на 250 км/ч");
            }
            else if (key.Modifiers == ConsoleModifiers.Shift && key.Key == ConsoleKey.DownArrow && height > 0)
            {
                height -= 500;
                Console.WriteLine("Высота уменьшена на 500 км/ч");
            }
            else if (key.Modifiers != ConsoleModifiers.Shift && key.Key == ConsoleKey.UpArrow)
            {
                height += 250;
                if (state == Mode.TAKEOFF)
                    state = Mode.FLY;
                Console.WriteLine("Высота увеличена на 250 км/ч");
            }
            else if (key.Modifiers == ConsoleModifiers.Shift && key.Key == ConsoleKey.UpArrow)
            {
                height += 500;
                if (state == Mode.TAKEOFF)
                    state = Mode.FLY;
                Console.WriteLine("Высота увеличена на 500 км/ч");
            }
            bool result = valuesWereChanged(speed, height, state);
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
            return result;
        }
    }
}