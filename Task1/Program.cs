namespace Task1
{
    /*
     * Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.
        a = 5; b = 7 -> max = 7
        a = 2 b = 10 -> max = 10
        a = -9 b = -3 -> max = -3
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter first number: ");
            int firstNumb = int.Parse( Console.ReadLine());
            Console.Write($"Enter second number: ");
            int secondNumb = int.Parse(Console.ReadLine());
            int max = firstNumb;
            if ( max < secondNumb ) max = secondNumb;
            Console.WriteLine($"a = {firstNumb}; b = {secondNumb} -> max = {max}");
            Console.ReadKey();
        }
    }
}
