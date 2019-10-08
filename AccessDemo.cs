using System;
namespace AccessProject
{
public class AccessDemo
{
private void Test1()
{
Console.WriteLine("private method is called");
}
internal void Test2()
{
Console.WriteLine("Internal method is called");
}
protected void Test3()
{
Console.WriteLine("protected method is called");
}
protected internal void Test4()
{
Console.WriteLine("protected internal method is called");
}
public void Test5()
{
Console.WriteLine("public method is called");
}
static void Main(string[] args)
{
AccessDemo a=new AccessDemo();
   a.Test1();
   a.Test2();
   a.Test3();
   a.Test4();
   a.Test5();
Console.ReadLine();
}
}
}
