//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int ReadInt(string massage)
{
    System.Console.Write($"{massage} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int a = ReadInt("Введите число пятизначное число > ");

int СomparA(int a)
{
    int a1 = a / 10000;
    int a2 = a / 1000 % 10;
    int a3 = a / 100 % 10;
    int a4 = a / 10 % 10;
    int a5 = a % 10;
    if ((a1 == a5) && (a2 = a4))
    {
        System.Console.WriteLine("Число полиндром");
    }
    else
    {
        System.Console.WriteLine("Число не полиндром");
    }
}


bool ValidateA(int a)
{
    bool res = 100000 > a > 9999;
    if (res)
    {
        System.Console.WriteLine("Число не пятизначное");
        return false;
    }

    return true;
}

if (ValidateA(a))
{
    ComparA(a);
}
