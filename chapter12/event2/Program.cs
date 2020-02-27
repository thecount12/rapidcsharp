using System;
public class Program
{
    public static void Main()
    {
        NumberSub nc = new NumberSub(42);
        nc.DisplayMoney();
        nc.DisplayNumber();
        nc.PrintDec();
        nc.DisplayTemp();
        nc.DisplayHex();
    }
}
class NumberSub 
{     
    private DisplayData _displayHelper;     
    public NumberSub(int x)     
    {         
        _value = x;           
        _displayHelper = new DisplayData();               
        _displayHelper.beforeDisplayEvent += before_display_event; // subscribe
    }      
    void before_display_event()     
    {         
        Console.WriteLine("Before Display Event Handler");     
    }
    private int _value;
    public int Value  { get; set; }
    public void DisplayMoney()     
    {         
        _displayHelper.DisplayMoney(_value);     
    }     
    public void DisplayNumber()     
    {         
        _displayHelper.DisplayNumber(_value);     
    }
    public void PrintDec()
    {
        _displayHelper.PrintDecimal(_value);
    }
    public void DisplayTemp()
    {
        _displayHelper.DisplayTemperature(_value);
    }
    public void DisplayHex()
    {
        _displayHelper.DisplayHexadecimal(_value);
    }
}
public class DisplayData 
{         
    public delegate void BeforeDisplay();  // declare delegate   
    public event BeforeDisplay beforeDisplayEvent; // declare event of type delegate
    public DisplayData()     {     }     
    public void DisplayNumber(int x)     
    {         
        //call delgate before display        
        if (beforeDisplayEvent != null)             
        beforeDisplayEvent();         
        System.Console.WriteLine("Number: {0,-12:N0}", x);     
    }
    public void PrintDecimal(int dec)
    {         
        if (beforeDisplayEvent != null)             
        beforeDisplayEvent();           
        System.Console.WriteLine("Decimal: {0:G}", dec);     
    }     
    public void DisplayMoney(int amount)     
    {         
        if (beforeDisplayEvent != null)             
        beforeDisplayEvent();         
        System.Console.WriteLine("Money: {0:C}", amount);     
    }     
    public void DisplayTemperature(int x)     
    {        
        if (beforeDisplayEvent != null)             
        beforeDisplayEvent();         
        System.Console.WriteLine("Temperature: {0,4:N1} F", x);     
    }
    public void DisplayHexadecimal(int dec)
    {
       if(beforeDisplayEvent!=null)
       beforeDisplayEvent();
       System.Console.WriteLine("Hex: {0:X}", dec); 
    }
}

