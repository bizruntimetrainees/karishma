using System;
namespace Demo7Project
{
class First
{
public int x=100;
}
class Second
{
	public int x;
	public Second(int x)
	{
		this.x=x;
	}
}
class TestClasses
{
static void Main(string[] args)
{
First f=new First();
First f1=new First();
First f2=new First();
Console.WriteLine(f.x+" "+f1.x+" "+f2.x);
Console.ReadLine();

Second s=new Second(100);
Second s1=new Second(200);
Second s2=new Second(300);
Console.WriteLine(s.x+" "+s1.x+" "+s2.x);
Console.ReadLine();
}
}
}