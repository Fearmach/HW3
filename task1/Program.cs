// Написать программу, которая принимает на вход пятизначное число и проверяет является ли оно палиндромом (14212 - нет, 23432 - да)

System.Console.WriteLine("Введите пятизначное число: ");
string? num = Console.ReadLine();
int length = num!.Length;

if (length == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{num} - не палиндром");
    }
    
}
else
{
    System.Console.WriteLine("Не корректное число");
}




