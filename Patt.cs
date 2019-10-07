using System;
namespace Pattern
{
class patt
{
public static void Main(string[] args)
{
	Console.WriteLine("enter no");
	int rows=Int32.Parse(Console.ReadLine());
	for(int r=1;r<=rows;r++)
	{
	for(int c=0;c<=r;c++)
	{
	Console.Write(r);
	}	
		Console.WriteLine();
		}
		}
		}
}