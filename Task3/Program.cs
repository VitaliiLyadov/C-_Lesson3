// Задача 3: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
int ReadInt(string massage)
{
    System.Console.Write($"{massage} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int ax = ReadInt("Введите X1 > ");
int ay = ReadInt("Введите Y1 > ");
int bx = ReadInt("Введите X2 > ");
int by = ReadInt("Введите Y2 > ");

int coordx = (ax - bx);
int coordy = (ay - by);
double a = Math.Sqrt(Math.Pow(coordx, 2) + Math.Pow(coordy, 2));

System.Console.WriteLine($"Расстояние между точками {a}");