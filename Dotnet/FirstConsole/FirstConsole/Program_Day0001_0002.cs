using System;

namespace FirstConsole
{
    class Program_Day0001_0002
    {
        static void Main_Day0001_0002(string[] args)
        {

            //Master In C# 
            // 5/6 points 
            // Practice 
            // String 
            // Number 
            // Boolean 
            // Collection 
            // Date/time 

            // File System




            // Emogies 

            //Or Preparing for interview 

            string str = "";
          //number 
          //

            string[] employeeNames = { "Abhay", "Shridhar", "Akash", "Ajay", "Vijay", "Karan" };

            PrintStartWith(employeeNames, "A");
            PrintStartWith(employeeNames, "P");
            PrintStartWith(employeeNames, "K");
            PrintEndWith(employeeNames, "r");
            PrintEndWith(employeeNames, "y");
            PrintEndWith(employeeNames, "h");


            //Want to start with "A";

            Console.WriteLine("Hello World!");
        }


        public static void PrintStartWith(string[] employeeNames, string Key)
        {
            string[] result = new string[employeeNames.Length];
            int j = 0;
            for (int i = 0; i < employeeNames.Length; i++)
            {
                if (employeeNames[i].StartsWith(Key))
                {
                    result[j++] = employeeNames[i];
                }
            }
            Console.WriteLine("All Employees Start With " +Key );
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != null)
                {
                    Console.WriteLine(result[i]);
                }
            }
        }



        public static void PrintEndWith(string[] employeeNames, string Key)
        {
            string[] result = new string[employeeNames.Length];
            int j = 0;
            for (int i = 0; i < employeeNames.Length; i++)
            {
                if (employeeNames[i].EndsWith(Key))
                {
                    result[j++] = employeeNames[i];
                }
            }
            Console.WriteLine("All Employees End With " + Key);
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != null)
                {
                    Console.WriteLine(result[i]);
                }
            }
        }


    }
}
