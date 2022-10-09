// // Напишите программу, которая задает массив из 8 элементов и выводит их на экран

Console.Clear();

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    Random rnd = new Random();
    while (index < length)
    {
        collection[index] = rnd.Next(0, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
int[] array = new int[8];

FillArray(array);
Console.WriteLine();
PrintArray(array);
