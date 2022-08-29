
// Задача: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*123321
void Polindrom(long number)
{
string numberText = Convert.ToString(number); // конвертируем в строку
long length = numberText.Length; //вводим переменную и узнаем  длину (количество символов)

long current = number; // переменная
long result = 0; // пременная в которойхраним отзеркаленную цифру
long i = Convert.ToInt64(Math.Pow(10, length)); // возводим 10 в степень (число длины строки)

while(number > 0)
{
   long a = number % 10; // переменная в  которую ложим крайнее правое число от number 123321
//забираем 1 и ее не учитываем
//
   number = number / 10; // удаляем правое число
   result = result + a  * (i/10); // переставляем крайнюю правую цифру в левую
   i = i / 10; цикл на уменьшение разрядности
}
if(current == result)
    Console.Write($" число {current} - является палиндромом");
else
    Console.Write($" число {current} -  не является палиндромом");
}
Console.Write("введите число: ");
long n1 = Convert.ToInt64(Console.ReadLine());
Polindrom(n1);  
*/

/*
// Задача: Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.


double FindDisctasnse(double x1, double y1, double x2, double y2, double z1, double z2)
{
   return Math.Sqrt((x2 - x1) * ((x2 - x1)) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}

Console.Write("введите 1 координаты: ");
double xA = Convert.ToInt32(Console.ReadLine());
double yA = Convert.ToInt32(Console.ReadLine());
double zA = Convert.ToInt32(Console.ReadLine());

Console.Write("введите 2 координаты: ");
double xB = Convert.ToInt32(Console.ReadLine());
double yB = Convert.ToInt32(Console.ReadLine());
double zB = Convert.ToInt32(Console.ReadLine());

double dist = FindDisctasnse(xA, yA, xB, yB, zA, zB);
Console.Write($"расстояние междудвухочек коорднат в 2d - {dist}");
*/

/*
//Задача: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void FindCube(int n)
{
   int i = 1;
   while(i <= n)
   {
      if(i == n) Console.Write($"{i * i * i}. "); // если счетчик равен n, топосле ничего не идет, будет точка
      else Console.Write($"{i * i * i}, ");
      i++;      
   }
}

Console.Write("введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
FindCube(n1);  
*/