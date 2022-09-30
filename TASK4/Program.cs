// 
 
 int number = int.Parse(Console.ReadLine())!;

 if (number<0)
 {
    number = number*-1;
 }

if (number >=100 && number <1000)
{

 int lastNumber = number%10;
 Console.WriteLine(lastNumber);
}
else 
{
    Console.WriteLine("error");
}

