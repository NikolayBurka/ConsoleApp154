int[] array = { 8, -1, 4, 16, -5, 3 };
int max = array[0];int indexmax = 0;
for(int i=0;i<array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i]; indexmax = i;
    }
}
Console.WriteLine($"max={max} indexmax={indexmax}");