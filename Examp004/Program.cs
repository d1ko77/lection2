void FillArray(int[] collect)
{
    int length = collect.Length;
    int index = 0;
    while (index < length)
    {
        collect[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collect, int find)
{
    int count = collect.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collect[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}



int[] array = new int[100];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 99);
Console.WriteLine(pos);