using System;
namespace Demo4Project
{
class ConParaa
{ 
int x;
public ConParaa(int i)
{ 
x=i;
Console.WriteLine("constructor is called="+i);
}
public void Display()
{ 
Console.WriteLine("value="+x);
}

static void Main(string[] args)
{
ConParaa d=new ConParaa(10);
ConParaa s=new ConParaa(20);
d.Display();
s.Display();
Console.ReadLine();
} 
}
}
