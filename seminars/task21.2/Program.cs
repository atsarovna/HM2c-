// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// A(3,6); B(2,1) -> 5,09
// A(7,-5); B(1,-1) -> 7,21

//c помощью функции Math.Sqrt(double) - теорема Пифагора: квадрат гипотенузы равен сумме квадратов катета

/*Console.Write("Enter coordinates X of first dot: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter coordinates Y of first dot: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter coordinates X of second dot: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter coordinates Y of second dot: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double a = (x2- x1)*(x2- x1);  //расстояние/размер 1 катета(нижняя сторона треугольника) - в квадрате или Math.Pow
double b = (y2 - y1)*(y2 - y1); //расстояние/размер 2 катета(сторона справа)
double c = a+b; // сумма квадратов катетов
double distance = Gipotenusa(c); // объявить переменную типа double и она равна функции Гипотенуза,которая принимает аргумент с

double Gipotenusa(double sum) // sum - сумма катетов
{
    return Math.Sqrt(sum); //возвращает корень из суммы катетов
}
Console.WriteLine($"Distance between 2 dots = {distance}");
*/

//второе решение
/*Console.Write("Enter coordinates X of first dot: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter coordinates Y of first dot: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter coordinates X of second dot: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter coordinates Y of second dot: ");
int y2 = Convert.ToInt32(Console.ReadLine());
*/

int x1 = coordinate("x","A");
int y1 = coordinate("y","A");
int x2 = coordinate("x","B");
int y2 = coordinate("y","B");
int coordinate(string coorName, string pointName)
{
    Console.Write($"Enter coordinates {coorName} of dot {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Coordinates are: A ({x1},{y1}) и B ({x2},{y2})");

double katet1 = Math.Pow((x2-x1),2);
double katet2 = Math.Pow((y2-y1),2);
double gipotenusa = Math.Pow((katet1 + katet2),0.5); // Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow(y2-y1),2)

Console.WriteLine($"Distance between 2 dots = {gipotenusa}");