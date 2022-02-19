using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FirstConsole
{
    public class Program_Day0002_0007
    {

        static void Main(string[] args)
        {

         var data=   File.ReadAllText(@"D:\abhay\ShridharMVCCLass\ShridhardDotnet\Dotnet\FirstConsole\FirstConsole\This.txt");


            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Name", "Abhay");
            dict.Add("Address", "2333");

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }

}