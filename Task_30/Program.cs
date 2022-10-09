// // Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном поряжке
Console.Clear();

int[] arr = new int[8];


void FillArray(int[] ar)
{
    Random rnd = new Random();
    for (int i = 0; i < ar.Length; i++)
    {
        ar[i] = rnd.Next(0, 2);
    }
}

FillArray(arr);

 void PrintArray(int[] ar)
{
    int count = ar.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write ($"{ar[position]}, ");
        position++;
    }
}

PrintArray(arr);