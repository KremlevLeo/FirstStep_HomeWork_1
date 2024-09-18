namespace Task4
{
    /*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    5 -> 2, 4
    8 -> 2, 4, 6, 8
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int numb = int.Parse(Console.ReadLine());
            int count = 2;
            Console.Clear();
            Console.Write($"{numb} -> ");
            while (count <= numb)
            {
                if (count % 2 == 0) Console.Write($"{count} ");
                count++;
            }
            Console.ReadKey();
        }
    }
}
