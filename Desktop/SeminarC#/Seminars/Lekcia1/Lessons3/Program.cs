// // // Напишите программу, которая принимает на вход координаты
// // //  точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер 
// // //  четверти плоскости, в которой 
// // // находится эта точка.

// // int FindQuart(int x, int y)
// // {
// //    if (x > 0 && y > 0) return 1;
// //    if (x < 0 && y > 0) return 2;
// //    if (x < 0 && y < 0) return 3;
// //    if (x > 0 && y < 0) return 4;

// //    return 0;
// // }

// // Console.WriteLine("Input X: ");
// // int x = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Input Y: ");
// // int y = Convert.ToInt32(Console.ReadLine());

// // int result = FindQuart(x, y);

// // Console.WriteLine($"Point width {x} &&{y} coordinates located at {result}");


// // Напишите программу, которая принимает на вход 
// // координаты двух точек и находит расстояние между
// //  ними в 2D пространстве.

// //A (3,6); B (2,1) -> 5,09
// //A (7,-5); B (1,-1) -> 7,21
// double FindDistance(double xa, double ya, double xb, double yb)
// {
//    return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)));

// }

// Console.WriteLine("Input cordinate X to A : ");
// double xa = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input cordinate Y to A : ");
// double ya = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input cordinate X to B : ");
// double xb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input cordinate Y to B : ");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between point A width coordinates({xa}, {ya}) and point B with coordinates({xb}, {yb} -> {FindDistance(xa, ya, xb, yb)})");

// Отсутствует аргумент, соответствующий 
// требуемому формальному параметру "y" из 
// "Math.Pow(double, double)"
// void FindQuart(int x)
// {
//    if (x == 1) Console.WriteLine("x > 0 && y > 0");
//    if (x == 2) Console.WriteLine("x < 0 && y > 0");
//    if (x == 3) Console.WriteLine("x < 0 && y < 0");
//    if (x == 4) Console.WriteLine("x > 0 && y < 0");
//    if (x == 0) Console.WriteLine("x = 0");
// }

// Console.WriteLine("Input X: ");
// int x = Convert.ToInt32(Console.ReadLine());


// FindQuart(x);

//  Напишите программу которая принимает на вход число (N)
//   и выдает на консоль квадраты чисел от 1 до N

// void Quaed(int n)
// {
//    int count = 1;

//    while (count <= n)
//    {

//       Console.WriteLine($"{count} - > {count * count} ");
//       count++;
//    }
// }

// Console.WriteLine("Input Numser: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Quaed(num);

