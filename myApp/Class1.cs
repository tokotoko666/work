using System;
using myApp;

class Class1
    {

    // private List<string> valueList;

    static void Main()
    {
        string str = "aaaaa";
        Console.WriteLine("start"); 

        Class2 c = new Class2();
        c.print(str);

        Class3 c3 = new Class3();
        c3.name ="siva";

        Console.WriteLine(c3.name);
        Console.WriteLine("end");

    }   
}