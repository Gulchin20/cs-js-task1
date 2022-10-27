using System;

public class Comparison
{
    public static void Main(string[] args)
    {
int a=12;
int b=4;
int c=5;
if (b<a && b<c)
{
    Console.WriteLine(b +" kicikdir");
}
else if (a<b && a<c)
{
    Console.WriteLine( a + " kicikdir");
}
else if (c<a && c<b)
{
    Console.WriteLine( c + " kicikdir");
}
else 
{
    Console.WriteLine("ededlerden ya 2-si ya da 3 de bir birine beraberdir");
}
 }
}