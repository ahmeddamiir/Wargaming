using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TaskA
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            string path;
            do
            {
                Console.Write("File path:");
                path = Console.ReadLine();
            } while (string.IsNullOrEmpty(path?.Trim()));

            // Read each line
            var itemList = File.ReadAllLines(path);
            
            // Key-Value pair variable 
            var runners = new Dictionary<string, string>();
                
            // --NOTICE-- Not enough errors to check in the following code and there maybe a lack of edge cases handling //
            // loop on each string and separate them in key value pair
            foreach (var item in itemList)
            {
                if (item != "")
                {
                    var thing = item.Split(';');
                    runners.Add(thing[1], thing[0]);
                }
            }

            // --OUTPUT-- // :)
            string runnerUp;
            runners.TryGetValue("2", out runnerUp);
            Console.WriteLine(runnerUp);
        }
    }
}