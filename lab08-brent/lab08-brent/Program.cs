using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace lab08_brent
{
    class Program
    {
        static void Main(string[] args)
        {
            // get features into a queriable thing
            JToken data = JObject.Parse(GetJson())["features"];


            Console.WriteLine("All the hoods");


            IEnumerable<string> alln = from JObject n in data select n["properties"]["neighborhood"].ToString();
            //WriteGen(alln);

            //non-empty
            IEnumerable<string> namedn = data.Where(x => x["properties"]["neighborhood"].ToString() != "")
                                             .Select(n => n["properties"]["neighborhood"].ToString());
            //WriteGen(namedn);

            //only unique
            IEnumerable<string> uniquen = data.Select(n => n["properties"]["neighborhood"].ToString())
                                              .Distinct();
            //WriteGen(uniquen);

            IEnumerable<string> combo = data.Select(n => n["properties"]["neighborhood"].ToString())
                                            .Where(x => x != "")
                                            .Distinct();
            WriteGen(combo);
                                               
        }

        /// <summary>
        /// Gets the data in its own method before processing
        /// </summary>
        /// <returns>data</returns>
        public static string GetJson()
        {
            return File.ReadAllText(@"..\..\..\..\..\data.json");
        }

        /// <summary>
        /// Prints a generic enumerable of strings to the console
        /// </summary>
        /// <param name="gen">strings to be printed</param>
        public static void WriteGen(IEnumerable<string> gen)
        {
            foreach (string x in gen)
            {
                Console.WriteLine(x);
            }
        }
    }
}