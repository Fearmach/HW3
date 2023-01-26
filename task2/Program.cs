// Написать программу, которая принимает на вход координаты 2-х точек и находит расстояние между ними в 3D пространстве (A (3,6,8); B(2,1,-7) -> 15,84)

double[] coordsA = new double[3];
double[] coordsB = new double[3];

System.Console.WriteLine("Введите координаты x, точки A: ");
coordsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты y, точки A: ");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты z, точки A: ");
coordsA[2] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты x, точки B: ");
coordsB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты y, точки B: ");
coordsB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты z, точки B: ");
coordsB[2] = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt(Math.Pow (coordsA[0] - coordsB[0],2) + Math.Pow (coordsA[1] - coordsB[1],2) + Math.Pow (coordsA[2] - coordsB[2],2));

System.Console.WriteLine(S);