using System;
namespace Demo5Project
{
class CopyConPara
{ int x;
public CopyConPara(int i) 
{
	x=i;
	Console.WriteLine("constructor is called="+i);
}
public CopyConPara(CopyConPara obj)
{
x=obj.x;
}
public void Display()
{
Console.WriteLine("value="+x);
}
static void Main(string[] args)
{
CopyConPara c=new CopyConPara(10);
CopyConPara d=new CopyConPara(c);
c.Display();
d.Display();
Console.ReadLine();
} 
}
}