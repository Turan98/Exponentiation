double a;
double b = 1;
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Enter a:" );
a = Convert.ToDouble(Console.ReadLine() );

for (int i = 1; i  <= a; i++)
{
   b = i * i;
    Console.WriteLine(( i+"^2 = "+b));
}