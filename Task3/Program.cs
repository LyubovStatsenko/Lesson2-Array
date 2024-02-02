int n = 10;
int[] array = {2,5,8,15,2,72,9,5,7,4};
int i = 0;

while(i < n)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array [i]} ");
    }
 i = i + 1; 
}