using System;
namespace Demo6Project
{
class StaticCon
{
	static StaticCon()
{
Console.WriteLine("constructor is called");
}
static void Main(string[] args)
{
	Console.WriteLine("Main method  is excecuted");
}
}
}