
int Max(int a, int b, int c)
{
   int max = a;
   if (b > max) max = b;
   if (c > max) max = c;
   return max;
}

int[] array = { 11, 21, 31, 41, 51, 61, 71, 7, 2 };
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

//  Можно и так 
int max = Max(
   Max(a1, b1, c1),
   Max(a2, b2, c2),
   Max(a3, b3, c3));


Console.WriteLine(max);