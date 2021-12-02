using System;
using System.IO;
using System.Collections.Generic;
namespace _2
{
    class Program
    {
        private static string path = "B:\\CodeStuff\\C#\\Advent\\2\\input.txt";
        static void Main(string[] args)
        {
            StreamReader sr;

            int current = 0;
            Dictionary<int, int> nums = new Dictionary<int, int>();
            List<int> numsL = new List<int>();
            while(true)
            {
                sr = new StreamReader(path);
                while (!sr.EndOfStream)
                {
                    int num = Convert.ToInt32(sr.ReadLine());
                    numsL.Add(num);
                    if (nums.ContainsKey(current))
                    {
                        Console.WriteLine(current);
                        nums[current]++;
                        return;
                    }
                    else
                    {
                        nums.Add(current, 0);
                    }
                    current += num;                    
                }
            }            
        }
    }
}
