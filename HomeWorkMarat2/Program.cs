
 /*
 //ЗАДАЧА 10 :Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 789 109
 void SecondDigit(int number)    
{
   int leght = number % 100;
   int result = leght / 10;
   Console.WriteLine(result);
}
Console.Write("введите трехзначное число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
SecondDigit(n1);
*/


/*
// ЗАДАЧА 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

void ThreeDigit(int number)
{
   if(number >= 100) // на трехзначность проверили если больше то идем далее, 
//если нет то вывод ответа - нет третьей цифры
   {
      int current = number;
      int result = 0;
      while(current > 1000) //??????????????
      {
         current /= 10;
      }
      result = current % 10;
      Console.WriteLine($"третья цифра - {result}");
   }
   else
   {
      Console.WriteLine($"число не имеет третьей цифры");
   }
}
Console.Write("введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
ThreeDigit(n1);
*/


/*
// ЗАДАЧА 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.

void Weekend(int number)
{
if(number == 1)
Console.WriteLine($"понедельник");
if(number == 2)
Console.WriteLine($"вторник");
if(number == 3)
Console.WriteLine($"среда");
if(number == 4)
Console.WriteLine($"четверг");
if(number == 5)
Console.WriteLine($"пятница");
if(number == 6)
Console.WriteLine($"Ура выходной");
if(number == 7)
Console.WriteLine($"Ура выходной");
}

Console.Write("введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Weekend(n1);
*/
