    //          0   1   2    3   4   5   6   7   8   9
int[] array = { 1, 32, 13, 246, 25, 46, 73, 82, 19, 25 };

int n = array.Length;
int find = 25;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
