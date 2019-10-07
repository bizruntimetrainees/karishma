using System;
namespace Demo2Project
{
class ExplConPara
{
public ExplConPara(int i)
{
Console.WriteLine("constructor is called="+i);
}
static void Main(string[] args)
{
	ExplConPara d=new ExplConPara(10);
	ExplConPara c=new ExplConPara(20);

Console.ReadLine();
}
}
}

