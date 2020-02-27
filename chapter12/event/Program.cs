using System;

class Program
{
  static void Main()
  {
    AddNumber addnum = new AddNumber();
    addnum.FoundFive += a_FoundFive;
    int Answer = addnum.Add(1, 2);
    System.Console.WriteLine("Answer = {0}", Answer);
    Answer = addnum.Add(2, 2);
    System.Console.WriteLine("Answer = {0}", Answer);
    Answer = addnum.Add(4, 6);
    System.Console.WriteLine("Answer = {0}", Answer);
    Answer = addnum.Add(2, 8);
    System.Console.WriteLine("Answer = {0}", Answer);
  }
 
  static void a_FoundFive(object sender, Multiples e)
  {
    System.Console.WriteLine("Multiple of five reached: ", e.Total);
  }
}
 
public class AddNumber
{
  public event EventHandler<Multiples> FoundFive;
  public int Add(int x, int y)
  {
    int Sum = x + y;
    if ((Sum % 5 == 0) && (FoundFive != null))
    { FoundFive(this, new Multiples(Sum)); }
    return Sum;
  }
}
 
public class Multiples : EventArgs
{
  public Multiples(int MyTotal)
  { Total = MyTotal; }
  public int Total { get; set; }
}