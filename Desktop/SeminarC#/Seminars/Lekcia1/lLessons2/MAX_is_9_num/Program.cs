int Max(int a, int b, int c)
{
   int max = a;
   if (b > max) max = b;
   if (c > max) max = c;
   return max;
}

int a1 = 10;
int b1 = 20444;
int c1 = 30;

int a2 = 10011;
int b2 = 200;
int c2 = 300;

int a3 = 1000;
int b3 = 2000;
int c3 = 3000;

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