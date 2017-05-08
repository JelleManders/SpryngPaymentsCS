using System;
using SpryngPaymentsCS.SpryngPayments.cs;

public class Tester
{
    static void main(string[] args)
    {
        SpryngPayments spryng = new SpryngPayments();
        spryng.GetRequest("http://www.microsoft.com");
        Console.ReadKey();
    }
}
