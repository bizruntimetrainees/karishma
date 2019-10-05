using System;
namespace logicalPrograms
{
class Add
{ 

public static void Main(string[] args)
{
	Console.WriteLine("enter no");
	int count=Int32.Parse(Console.ReadLine());
	int sum=0;
	for(int i=0;i<=count;i++)
	{
		sum+=i;
	}
	Console.WriteLine($@"sum of number {count} equalto {sum}");
	Console.ReadKey();
	
}
}
}