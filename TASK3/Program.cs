//. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2"


/*Console.WriteLine("Enter number");

int N = int.Parse(Console.ReadLine());

if (N<0)
{
    N = N*(-1);
}
if (N > 0)
{
    int number = N;
N = N*(-1);
while ( N <=  number)
{
    Console.WriteLine(N);
    N++;
}
}*/


//2
Console.WriteLine("Enter number");

int N = int.Parse(Console.ReadLine());

if (N > 0)
{
    int number = N;
N = N*(-1);
while ( N <=  number)
{
    Console.WriteLine(N);
    N++;
}}
if (N < 0)
{
    int number = N;

while ( N >=  number)
{
    Console.WriteLine(N);
    N++;
}}