using static System.Console;

WriteLine("Введите число:");

int а = int.Parse(ReadLine()!);
//int b = Convert.ToInt32(ReadLine());
WriteLine($"Квадрат числа {а} равен {а*а}");