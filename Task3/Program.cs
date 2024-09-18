namespace Task3
{
    /*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    4 -> да
    -3 -> нет
    7 -> нет
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a nubmer: ");
            double number = double.Parse(Console.ReadLine());
            if (number % 2 == 0) Console.WriteLine($"{number} -> Yes");
            else Console.WriteLine($"{number} -> No");
            Console.ReadKey();
        }
    }
}
