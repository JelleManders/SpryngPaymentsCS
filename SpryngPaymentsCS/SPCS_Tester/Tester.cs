using System.Web;
using System.Net;
using SpryngPaymentsCS;
using System;
using SpryngPaymentsCS.Models;

public class Tester
{
    static void Main(string[] args)
    {
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

        SpryngPayments spryng = new SpryngPayments("fb1XahIMiNXz5dT2z9OclYbokNdiLOfErDitngA2Gb0", true);

        Account myAccount = spryng.account.get("58e755e691fbd750f34db63d");

        Console.WriteLine("\n - Result: " + myAccount.getName());
        Console.ReadKey();
    }
}
