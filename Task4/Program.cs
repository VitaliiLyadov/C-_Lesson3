// Задача 4: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int ReadInt(string massage)
{
    System.Console.Write($"{massage} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int a = ReadInt("Введите число > ");
for (int i = 1; i <= a; i++)
{
    
    System.Console.Write($" {Math.Pow(i,2)}");
}
