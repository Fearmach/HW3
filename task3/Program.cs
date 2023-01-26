// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N (3 -> 1,8,27; 5 -> 1, 8, 27, 64, 125)

System.Console.WriteLine("Введите число: ");
double N = Convert.ToInt32(Console.ReadLine());

for (double i = 1; i <= N; i++)
{
    System.Console.WriteLine($"{Math.Pow(i,3)}");
}
