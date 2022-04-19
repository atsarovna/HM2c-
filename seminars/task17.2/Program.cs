// та же задача,что и 17. только со 2 семинара

Console.Write("Enter coordinates (x): ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter coordinates (y): ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0) // || - или, выполняется либо первое либо второе условие
{
    Console.WriteLine("X and Y can't be equal 0");
    return;
}

int quarterNumber = 1;
if (x < 0 && y > 0)
{
    quarterNumber = 2;
}
if (x < 0 && y < 0)
{
    quarterNumber = 3;
}
if (x > 0 && y < 0)
{
    quarterNumber = 4;
}
Console.WriteLine($"Dot is in quarter: {quarterNumber}"); //Специальный знак $ идентифицирует строковый литерал как интерполированную строку. Интерполированная строка — это строковый литерал, который может содержать выражения интерполяции. При разрешении интерполированной строки в результирующую элементы с выражениями интерполяции заменяются строковыми представлениями результатов выражений. 
