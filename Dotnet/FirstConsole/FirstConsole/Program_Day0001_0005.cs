using System;

namespace FirstConsole
{
    class Program_Day0001_0005

    {
        static void Main_Day0001_0005(string[] args)
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

         var result= GetCondition(employeeNames, "A", "StartsWith");
            Console.WriteLine("All Employees Start With A");
            Print(result);
            result = GetStartWith(employeeNames, "P");
            Console.WriteLine("All Employees Start With P");
            Print(result);
            result = GetStartWith(employeeNames, "K");
            Console.WriteLine("All Employees Start With K");
            Print(result);

            result = GetEndWith(employeeNames, "r");
            Console.WriteLine("All Employees End With r");
            Print(result);

            result = GetEndWith(employeeNames, "y");
            Console.WriteLine("All Employees End With y");
            Print(result);


            result = GetContains(employeeNames, "b");
            Console.WriteLine("All Employees Conatains b");
            Print(result);


            //Want to start with "A";

            Console.WriteLine("Hello World!");
        }


        public static void Print(string[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != null)
                {
                    Console.WriteLine(result[i]);
                }
            }
        }


        public static string[] GetCondition(string[] employeeNames, string Key, string condition)
        {
            string[] result = new string[employeeNames.Length];
            int j = 0;
            for (int i = 0; i < employeeNames.Length; i++)
            {
                if (condition.Equals("StartsWith"))
                {
                    if (employeeNames[i].StartsWith(Key))
                    {
                        result[j++] = employeeNames[i];
                    }
                } else if (condition.Equals("EndsWith"))
                {
                    if (employeeNames[i].EndsWith(Key))
                    {
                        result[j++] = employeeNames[i];
                    }
                }
                else if (condition.Equals("Contains"))
                {
                    if (employeeNames[i].Contains(Key))
                    {
                        result[j++] = employeeNames[i];
                    }
                }

            }


            return result;

        }
        public static string[] GetStartWith(string[] employeeNames, string Key)
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


            return result;
           
        }



        public static string[] GetEndWith(string[] employeeNames, string Key)
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
            return result;
        }

        public static string[] GetContains(string[] employeeNames, string Key)
        {
            string[] result = new string[employeeNames.Length];
            int j = 0;
            for (int i = 0; i < employeeNames.Length; i++)
            {
                if (employeeNames[i].Contains(Key))
                {
                    result[j++] = employeeNames[i];
                }
            }
            return result;
        }


    }
}
