// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
int B = A / 100 % 10; 
if (B % 10 > 0) 
{
    Console.Write("Третья цифра ");
    Console.WriteLine(B);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}

