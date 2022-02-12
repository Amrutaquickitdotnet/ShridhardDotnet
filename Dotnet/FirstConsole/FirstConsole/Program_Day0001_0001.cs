using System;

namespace FirstConsole
{
    class Program_0001
    {
        static void Main_0001(string[] args)
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
            
            string[] result = new string[employeeNames.Length];
            int j = 0;
            for (int i = 0; i < employeeNames.Length; i++)
            {
                if (employeeNames[i].StartsWith("A"))
                {
                    result[j++] = employeeNames[i];
                }
            }
            Console.WriteLine("All Employees Start With A");
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i]!=null )
                {
                    Console.WriteLine(result[i]);
                }
            }

            Console.WriteLine("All Employees Start With P");

            result = new string[employeeNames.Length];
            j = 0;
            for (int i = 0; i < employeeNames.Length; i++)
            {
                if (employeeNames[i].StartsWith("P"))
                {
                    result[j++] = employeeNames[i];
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != null)
                {
                    Console.WriteLine(result[i]);
                }
            }


            result = new string[employeeNames.Length];
            j = 0;
            for (int i = 0; i < employeeNames.Length; i++)
            {
                if (employeeNames[i].StartsWith("K"))
                {
                    result[j++] = employeeNames[i];
                }
            }
            Console.WriteLine("All Employees Start With K");
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != null)
                {
                    Console.WriteLine(result[i]);
                }
            }




            //Want to start with "A";

            Console.WriteLine("Hello World!");
        }
    }
}
