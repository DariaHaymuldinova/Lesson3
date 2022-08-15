// 
double getDistance(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
}
Console.WriteLine("Введите координаты точки А:");
Console.WriteLine("АX:");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("АY:");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("АZ:");
int za = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
Console.WriteLine("BX:");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("BY:");
int yb = int.Parse(Console.ReadLine());
Console.WriteLine("BZ:");
int zb = int.Parse(Console.ReadLine());
Console.WriteLine($"Расстояние между точками: {getDistance(xa, ya, za, xb, yb, zb)}");


