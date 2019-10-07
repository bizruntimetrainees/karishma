using System;
namespace Demo1Project
{
class ConDemo
{
int i;
public ConDemo()
{
Console.WriteLine("constructor is called="+i);
}
static void Main(string[] args)
{
ConDemo d=new ConDemo();
//Console.WriteLine("value="+d.i);
Console.ReadLine();
}
}
}