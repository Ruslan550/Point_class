using System;

namespace PointSYS
{
    class Point
    {
        private int x;
        private int y;

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            set
            {
                if (value > 0)
                {
                    x = value;
                }
                else
                {
                    throw new Exception("Not found ;");
                }
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                if (value > 0)
                {
                    y = value;
                }
                else
                {
                    throw new ArgumentException("Not found 0 !!!");
                }
            }
        }

        public void Showdata()
        {
            Console.WriteLine($"Point score X: {x}, Y: {y}");
        }
    }

    class Counter
    {
        private int correctCounter;
        private int minCorrect;
        private int maxCorrect;

        public Counter(int min, int max, int cor)
        {
            CORRECTCOUNTER = cor;
            MinCounter = min;
            MaxCounter = max;
        }

        public int CORRECTCOUNTER
        {
            get { return correctCounter; }
            set
            {
                if (value < minCorrect || value > maxCorrect)
                {
                    throw new Exception("Not found counter ");
                }
                else
                {
                    correctCounter = value;
                }
            }
        }

        public int MaxCounter
        {
            get { return maxCorrect; }
            set { maxCorrect = value >= minCorrect ? value : minCorrect; }
        }

        public int MinCounter
        {
            get { return minCorrect; }
            set { minCorrect = value >= minCorrect ? value : minCorrect; }
        }

        public void Increment()
        {
            if (correctCounter < maxCorrect)
            {
                correctCounter++;
            }
            else
            {
                throw new ArgumentException("Not found 0 increment !");
            }
        }

        public void Reset()
        {
            correctCounter = minCorrect;
        }

        public int GetCurrent()
        {
            return correctCounter;
        }
    }

    class Program
    {
        static void Main()
        {
            Counter c1 = new Counter(0, 100, 0);

            Point point1 = new Point(5, 10);
            point1.Showdata();

            c1.Increment();
            Console.WriteLine($"Current Counter: {c1.GetCurrent()}");

            c1.Reset();
            Console.WriteLine($"Reset Counter: {c1.GetCurrent()}");
        }
    }
}
