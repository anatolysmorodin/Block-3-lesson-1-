// Показать вторую цифру трёхзначного числа //

Console.WriteLine("Введите трехзначное число");
int A = int.Parse(Console.ReadLine()!);
int B = A / 10 % 10 ;
Console.WriteLine(B);
