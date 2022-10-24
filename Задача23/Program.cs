// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine()!);

int[] fillArray(int N)
{
    int[]  qube = new int[N];
    for (int i = 0; i < N; i++) 
    {
        qube[i] = (i+1)*(i+1)*(i+1);
    }
    return qube;
}

void printArray(int[] array, int N)
{
    for (int i = 0; i < N; i++)
    {
        Console.Write(array[i] + " ");
    }
}

printArray(fillArray(N), N);