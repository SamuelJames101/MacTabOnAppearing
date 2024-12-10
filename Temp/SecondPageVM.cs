using System;

namespace Temp;

public class SecondPageVM
{
    public string MyText => "1) First text not set in on appearing/ binding";

    public SecondPageVM()
    {
        Console.WriteLine("SecondPageVM constructed");
    }
}
