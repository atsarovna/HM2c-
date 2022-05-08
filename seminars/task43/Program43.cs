/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


double InputNumbers(string name)
{
    Console.Write($"Enter the value {name}:");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double k1 = InputNumbers("k1");
double b1 = InputNumbers("b1");
double k2 = InputNumbers("k2");
double b2 = InputNumbers("b2");
 
double x = -(b1 - b2) / (k1 - k2); //вывела X из двух уравнений, подставив второе в первое
double y = k1 * x + b1; //подставляем значение x в любое уравнение
 
x = Math.Round(x,2); //Math.Round - Округляет значение до ближайшего целого или указанного количества десятичных знаков.
y = Math.Round(y,2);
 
Console.WriteLine($"The intersection point of two straight lines: ({x};{y})");
