/* 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	3 -> Среда 
5 -> Пятница*/

Console.WriteLine(" Введите номер дня недели");
int numberWeek = int.Parse(Console.ReadLine());

//1
/*if (numberWeek<1 || numberWeek>7)
    {
        Console.WriteLine( "error");
        }


if (numberWeek == 1)
{
    Console.WriteLine(" Monday");
}
if (numberWeek == 2)
{
    Console.WriteLine(" Tuesday");
}
if (numberWeek ==3)
{
Console.WriteLine("Wednesday");
}
if ( numberWeek == 4)
{
    Console.WriteLine("Thursday");

}
if (numberWeek == 5)
{
    Console.WriteLine("Friday");
}
if (numberWeek == 6)
{
    Console.WriteLine("Saturday ");
}
if (numberWeek == 7)
{
    Console.WriteLine("Hurray! Sunday!");
}*/

//2 
switch(numberWeek)
{
    case(1): 
    Console.WriteLine(" Monday");
    break; 

    case(2): 
    Console.WriteLine(" Tuesday");
    break;

    case(3): 
    Console.WriteLine("Wednesday");
    break;

    case(4): 
    Console.WriteLine("Thursday");
    break;

    case(5): 
    Console.WriteLine("Friday");
    break;

    case(6): 
    Console.WriteLine("Saturday");
    break;

    case(7): 
    Console.WriteLine("Hurray! Sunday!");
    break;

    default: 
    Console.WriteLine("error");
    break;

}


//String.Array ["monday", ]

//1
/*string name = Convert.ToString("Day"+numberWeek);
Console.WriteLine(name);

  string Day1 = "Monday" ;
 string Day2 = "Tuesday";
 string Day3 = "Wednesday";
 string Day4 = "Thursday";
  string Day5 = "Friday" ;
 string Day6 = "Saturday";
  string Day7 = "Sunday" ;
 
 string day = name;
Console.WriteLine(day);*/


//2
