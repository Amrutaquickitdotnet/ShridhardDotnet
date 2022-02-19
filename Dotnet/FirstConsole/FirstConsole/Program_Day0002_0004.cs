﻿using System;
using System.Collections.Generic;

namespace FirstConsole
{

    //public delegate R MyFunc<in T1,out R>(T1 str);

    //public delegate R MyFunc<T1,T2, R>(T1 t1, T2 t2);
    class Program_Day0002_0004
    {
        static void Main_0004(string[] args)
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


            int[] employeeIntNames = { 1,2,3,4,5,6,7 };


            string[] employeeNames = { "Abhay", "Shridhar", "Akash", "Ajay", "Vijay", "Karan" };

         var result= GetCondition(employeeNames, "A", "StartsWith");
            Console.WriteLine("All Employees Start With A");
            Print(result);
            result = ToGetArray( GetCondition(employeeNames,x=>x.StartsWith("P")));
            Console.WriteLine("All Employees Start With P");
            Print(result);
            //result = GetCondition(employeeNames, x => x.StartsWith("K"));
            //Console.WriteLine("All Employees Start With K");
            //Print(result);

            //result = GetCondition(employeeNames, x => x.EndsWith("r"));
            //Console.WriteLine("All Employees End With r");
            //Print(result);

            //result = GetCondition(employeeNames, Program_Day0002_0001.Dummy);
            //Console.WriteLine("All Employees End With y");
            //Print(result);


            //result = GetCondition(employeeNames, x => x.Contains("b"));
            //Console.WriteLine("All Employees Conatains b");
            //Print(result);

            //result = GetCondition(employeeNames, x => x.Contains("b") && x.StartsWith("A"));
            //Console.WriteLine("All Employees Conatains b and Start With A");
            //Print(result);

            int[] resultInt = ToGetArray(GetCondition(employeeIntNames, x=>x > 2));

            List<int> employeeIntListNames = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            List<int> resultIntList = ToGetList(GetCondition(employeeIntListNames, x => x > 2));


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

        public static bool Dummy(string str)
        {
            return false;
        }



        public static List<T> ToGetList<T>(IEnumerable<T> employeeNames)
        {

            List<T> result = new List<T>();

           
            foreach (var item in employeeNames)
            {
                result.Add(item);
            }

            return result;
        }

        public static T[] ToGetArray<T>(IEnumerable<T> employeeNames)
        {

            int i = 0;
            foreach (var item in employeeNames)
            {
                i++;
            }
            T[] result = new T[i];

            i = 0;
            foreach (var item in employeeNames)
            {
                result[i] = item;
            }

            return result;
        }


            public static IEnumerable<T> GetCondition<T>(IEnumerable<T> employeeNames, Func<T, bool> predicate)
        {
            //   T[] result = new T[employeeNames.Count];

             
            foreach(var item in employeeNames)
            {
                if (predicate(item))
                {
                        yield return item;
                }
            }


           

        }



        //public static List<T> GetCondition<T>(List<T> employeeNames, Func<T, bool> predicate)
        //{
        // //   T[] result = new T[employeeNames.Count];

        //    List<T> result = new List<T>();
        //    int j = 0;
        //    for (int i = 0; i < employeeNames.Count; i++)
        //    {
        //        if (predicate(employeeNames[i]))
        //        {
        //            //result[j++] = employeeNames[i];
        //            result.Add(employeeNames[i]);
        //        }
        //    }


        //    return result;

        //}



        //public static T[] GetCondition<T>(T[] employeeNames, Func<T, bool> predicate)
        //{
        //    T[] result = new T[employeeNames.Length];
        //    int j = 0;
        //    for (int i = 0; i < employeeNames.Length; i++)
        //    {
        //        if (predicate(employeeNames[i]))
        //        {
        //            result[j++] = employeeNames[i];
        //        }
        //    }


        //    return result;

        //}


        //public static int[] GetCondition(int[] employeeNames, Func<int, bool> predicate)
        //{
        //    int[] result = new int[employeeNames.Length];
        //    int j = 0;
        //    for (int i = 0; i < employeeNames.Length; i++)
        //    {
        //        if (predicate(employeeNames[i]))
        //        {
        //            result[j++] = employeeNames[i];
        //        }
        //    }


        //    return result;

        //}

        //public static string[] GetCondition(string[] employeeNames, Func<string,bool> predicate)
        //{
        //    string[] result = new string[employeeNames.Length];
        //    int j = 0;
        //    for (int i = 0; i < employeeNames.Length; i++)
        //    {
        //        if (predicate(employeeNames[i]))
        //        {
        //            result[j++] = employeeNames[i];
        //        }
        //    }


        //    return result;

        //}




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