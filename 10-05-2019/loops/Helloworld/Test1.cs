using System;
class Counter
{
int value;
int scaleFactor;
public Counter(int scaleFactor)
{
this.scaleFactor=scaleFactor;
}
public void Inc()
{
value+=scaleFactor;
}
public int Count
{
get{return value;}
}
}
class Test1
{
static void Main()
{
Counter c=new Counter(2);
c.Inc();
c.Inc();
Console.WriteLine(c.Count);
Counter d=new Counter(14);
d.Inc();
Console.WriteLine(d.Count);
}}