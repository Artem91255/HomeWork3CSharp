/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.*/

Console.Clear();

Console.WriteLine("Введите координаты для первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Введите координаты для второй точки");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("расстояние между точками в 3D пространстве равно " + distance(x1,x2,y1,y2,z1,z2));

double distance(double number1, double number2, double number3, double number4, double number5, double number6)
{
double a = number2-number1;
double b = number4-number3;
double c = number6-number5;

double e = Math.Pow(a,2) + Math.Pow(b,2) + Math.Pow(c, 2);
double f = Math.Sqrt(e);

return f;
}