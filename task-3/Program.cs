using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string numer = Console.ReadLine();
            if (numer.Contains('5')) {
                string a = numer.Trim('5');
                int b =Convert.ToInt32(a);
                Console.Write($"{b*(++b)}"+"25");
            }
        }
    }
}
