// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double GetDistanceToPoint3D (int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double distance = Math.Sqrt( Math.Pow(X2-X1, 2) + Math.Pow(Y2-Y1, 2) + Math.Pow(Z2-Z1, 2));

    return distance;
}

Console.WriteLine ("Введите X1: ");
int X1 = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите Y1: ");
int Y1 = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите Z1: ");
int Z1 = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите X2: ");
int X2 = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите Y2: ");
int Y2 = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите Z2: ");
int Z2 = int.Parse (Console.ReadLine());

double result = GetDistanceToPoint3D (X1, Y1, Z1, X2, Y2, Z2);
Console.WriteLine ($"Расстояние между точками ({X1}; {Y1}; {Z1}) и ({X2}; {Y2}; {Z2})  равно {Math.Round(result, 2)}");