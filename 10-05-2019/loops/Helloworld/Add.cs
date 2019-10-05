using System;
namespace logicalPrograms
{
class Add
{ 

public static void Main(string[] args)
{
	Console.WriteLine("enter no");
	int c=Int32.Parse(Console.ReadLine());
	int sum=0;
	for(int i=0;i<=c;i++)
	{
		sum+=i;
	}
	Console.WriteLine(c+" equalto "+sum);
	//Console.ReadKey();
	
}
}
}