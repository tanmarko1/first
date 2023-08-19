// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Напишите 2 числа, чтобы на выходе получить большее.");
System.Console.WriteLine("Первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 > num2)
    System.Console.WriteLine($"{Environment.NewLine}Max = {num1}");
    else
    System.Console.WriteLine($"{Environment.NewLine}Max = {num2}");