using System;
using System.Collections.Generic;
using System.Linq;

namespace Work_with_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("Александр", 25);
            myDictionary.Add("Петр", 35);
            myDictionary.Add("Иван", 20);
            myDictionary.Add("Семен", 15);
            myDictionary.Add("Андрей", 5);
            var result =
                from string name in myDictionary.Keys
                where myDictionary[name] > 18
                orderby name
                select name;

            Console.WriteLine("Старше 18:");

            foreach (string name in result)
                Console.WriteLine(name);
        }
    }
}
