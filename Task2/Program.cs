// Задача 2: Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y)

int ReadInt(string massage)
{
    System.Console.Write($"{massage} > ");
    return Convert.ToInt32(Console.ReadLine());
}
string GetRange(int quorter)
{
    if (quorter == 1)
    {
        return ("X > 0, Y > 0");
    }
    if (quorter == 2)
    {
        return ("X > 0, Y < 0");
    }
    if (quorter == 3)
    {
        return ("X < 0, Y < 0");
    }

    return ("X > 0, Y < 0");

}
bool ValidateXY(int quorter)
{
    bool res = quorter < 1 || quorter > 4;
    if (res)
    {
        System.Console.WriteLine("Такой четверти не существует");
        return false;
    }

    return true;
}

int numberQuorter = ReadInt("Введите четверть > ");
if (ValidateXY(numberQuorter))
{
    string range = GetRange(numberQuorter);
    System.Console.WriteLine(range);
}
