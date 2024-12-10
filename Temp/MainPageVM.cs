using System;

namespace Temp;

public class MainPageVM
{
    public string MyText => "1) First text not set in on appearing/ binding";

    public MainPageVM()
    {
        Console.WriteLine("SecondPageVM constructed");
    }
}
