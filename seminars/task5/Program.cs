Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a % 23 == 0) && (a % 7 == 0))
    Console.WriteLine("Кратно");
else
    Console.WriteLine("Не кратно");


// первый варинат (проверила три примера, сработало корректно.)
//if (a % 7 == 0)
//if (a % 23 == 0)
//{
//   Console.WriteLine("Кратно");
//}
//else 
//{
//  Console.WriteLine("Не кратно");
//}

// второй вариант
// {
//   Console.Write("Введите число: ");
//   int a = Convert.ToInt32(Console.ReadLine());
//   if (a % 7 == 0) {
//        if (n % 23 == 0)
//            Console.WriteLine("Кратно");
//        else 
//            Console.WriteLine("Не кратно");
//    } else
//            Console.WriteLine("Не кратно");
//    
// }