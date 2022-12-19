// Напишите программу, которая принимает на вход цифру, обозначающую день недели, //
// и проверяет, является ли этот день выходным.  //

Console.WriteLine("введите число от 1 до 7");
int day = int.Parse (Console.ReadLine()!);
int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;

if (day == a) {Console.WriteLine("Monday - working day");}
if (day == b) {Console.WriteLine("Tuesday - working day");}
if (day == c) {Console.WriteLine("Wednesday - working day");}
if (day == d) {Console.WriteLine("Thursday - working day");}
if (day == e) {Console.WriteLine("Friday - working day");}
if (day == f) {Console.WriteLine("Saturday - weekend");}
if (day == g) {Console.WriteLine("Sunday - weekend");}


