namespace Task2
{
    /*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter first number: ");
            int firstNumb = int.Parse(Console.ReadLine());
            Console.Write($"Enter second number: ");
            int secondNumb = int.Parse(Console.ReadLine());
            Console.Write($"Enter third number: ");
            int thirdNumb = int.Parse(Console.ReadLine());
            int max = firstNumb;
            if (max < secondNumb) max = secondNumb;
            if (max < thirdNumb) max = thirdNumb;
            Console.WriteLine($"{firstNumb}, {secondNumb}, {thirdNumb} -> {max}");
            Console.ReadKey();
        }
    }
}
