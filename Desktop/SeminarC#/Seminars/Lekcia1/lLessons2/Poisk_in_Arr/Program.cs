int[] array = { 1, 2, 3, 10, 35, 12, 6, 9, 18 };
int n = array.Length;
int find = 10;
int index = 0;

while (index < n)
{
   if (array[index] == find)
   {
      Console.WriteLine(index);
   }
   index++;
}