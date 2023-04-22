void FillArrray(int[] collection)
{
   int length = collection.Length;
   int index = 0;
   while (index < length)
   {
      collection[index] = new Random().Next(1, 15);
      index++;
   }
}

void PrintArrray(int[] collection)
{
   int length = collection.Length;
   int index = 0;
   while (index < length)
   {
      Console.WriteLine(collection[index]);
      index++;
   }
}

int IndexOf(int[] collection, int value)
{
   int count = collection.Length;
   int index = 0;
   int position = -1;
   while (index < count)
   {
      if (collection[index] == value)
      {
         position = index;
         break;
      }
      index++;
   }
   return position;
}
int[] array = new int[10];
FillArrray(array);
PrintArrray(array);
Console.WriteLine();
int index = IndexOf(array, 5);

Console.WriteLine(index);