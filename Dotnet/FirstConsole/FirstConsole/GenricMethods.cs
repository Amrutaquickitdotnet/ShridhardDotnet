using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
  public static class GenricMethods
    {


        public static T SetModel<T>(Dictionary<string,string> T obj)
        {




            return;


        }
         


            public static List<T> ToGetListc<T>(IEnumerable<T> employeeNames)
        {

            List<T> result = new List<T>();


            foreach (var item in employeeNames)
            {
                result.Add(item);
            }

            return result;
        }

        public static List<T> ToGetList<T>(this IEnumerable<T> employeeNames)
        {

            List<T> result = new List<T>();


            foreach (var item in employeeNames)
            {
                result.Add(item);
            }

            return result;
        }

        public static T[] ToGetArray<T>(this IEnumerable<T> employeeNames)
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


        public static T GetFirst<T>(this IEnumerable<T> employeeNames)
        {
            foreach (var item in employeeNames)
            {
                return item;
            }
            throw new Exception("nothing found");
        }


        public static T GetFirstDefault<T>(this IEnumerable<T> employeeNames)
        {
            foreach (var item in employeeNames)
            {
                return item;
            }
            return default(T);
        }

        public static IEnumerable<T> GetCondition<T>(this IEnumerable<T> employeeNames, Func<T, bool> predicate)
        {
            //   T[] result = new T[employeeNames.Count];


            foreach (var item in employeeNames)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }




        }


    }
}
