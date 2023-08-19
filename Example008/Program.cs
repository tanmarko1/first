// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Напишите 3 числа, чтобы на выходе получить большее.");
System.Console.Write("Первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Третье число:");
int num3 = Convert.ToInt32(Console.ReadLine());
    if (num3 < num1 && num1 > num2)
    System.Console.WriteLine($"Мах = {num1}"); 
    if (num3 < num2 && num2 > num1)
    System.Console.WriteLine($"Мах = {num2}");
    if (num1 < num3 && num3 > num2)
    System.Console.WriteLine($"Мах = {num3}");