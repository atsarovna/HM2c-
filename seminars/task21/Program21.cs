/* Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве. */
/* A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

int x1 = coordinate("x","A"); 
int y1 = coordinate("y","A");
int c1 = coordinate("c","A");
int x2 = coordinate("x","B");
int y2 = coordinate("y","B");
int c2 = coordinate("c","B");
int coordinate(string coorName, string pointName)
{
    Console.Write($"Enter coordinates {coorName} of dot {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Coordinates are: A ({x1},{y1},{c1}) and B ({x2},{y2},{c2})");

double katet1 = Math.Pow((x2-x1),2); // возведение в квадрат
double katet2 = Math.Pow((y2-y1),2);
double katet3 = Math.Pow((c2-c1),2);
double gipotenusa = Math.Pow((katet1 + katet2 + katet3),0.5); // Math.Sqrt((katet1) + (katet2) + (katet3));

Console.WriteLine($"Distance between 2 dots = {gipotenusa}");