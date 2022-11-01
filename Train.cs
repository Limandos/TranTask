using System;

namespace Task
{
    class Train
    {
        public Carriage Start { get; }
        public int Length { get; }

        public Train()
        {
            Random random = new Random();
            Length = random.Next(100);
            Start = new Carriage
            {
                Number = 1,
                Light = random.Next(2) == 1,
                Next = Start,
                Previous = Start
            };
            Carriage cycle = Start;
            for (int i = 0; i < Length - 1; i++)
            {
                Carriage carriage = new Carriage()
                {
                    Number = i + 2,
                    Light = random.Next(2) == 1,
                };
                cycle.Next = carriage;
                carriage.Previous = cycle;
                carriage.Next = Start;
                Start.Previous = carriage;

                cycle = cycle.Next;
            }
        }

        public int Count()
        {
            int count = 0;
            Carriage cycle = Start;
            bool counting = true;
            cycle.Light = true;
            while (counting)
            {
                cycle = cycle.Next;
                count++;
                if (cycle.Light)
                {
                    cycle.Light = false;
                    for (int i = 0; i < count; i++)
                    {
                        cycle = cycle.Previous;
                    }
                    if (cycle.Light)
                    {
                        count = 0;
                    }
                    else
                    {
                        counting = false;
                    }
                }
            }
            return count;
        }
    }
}