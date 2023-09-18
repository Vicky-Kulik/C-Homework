// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int[] GetCubesNum(int number)
{
    int[] cubeNum = new int [number];
    for (int i=0; i < number; i++)
    {
        cubeNum[i] = i*i*i;
    }

    return cubeNum;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int[] result = GetCubesNum(num);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
