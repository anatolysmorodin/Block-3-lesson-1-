// Найти максимальное из трех чисел //

int A = 25;
int B = 39;
int C = 18;

int max = A;
if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;

Console.WriteLine(max);