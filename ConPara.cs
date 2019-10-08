using System;
namespace Demo3Project
{
class ConPara
{
int x;
public ConPara(int i)
{
Console.WriteLine("constructor is called="+i);
}
public void Display()
{
Console.WriteLine("value="+x);
}
static void Main(string[] args)
{
ConPara c=new ConPara(10);
ConPara d=new ConPara(20);
c.Display();
d.Display();
 Console.ReadLine();
 }
 }
 }