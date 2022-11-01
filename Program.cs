using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
            Carriage cycle = train.Start;
            for (int i = 0; i < train.Length; i++)
            {
                Console.WriteLine($"{cycle.Number} is {cycle.Light}");
                cycle = cycle.Next;
            }
            Console.WriteLine($"\nMy answer is {train.Count()}.");
            Console.WriteLine($"\nTrue answer is {train.Length}.");
            Console.ReadKey();
        }
    }
}