using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps
{
    class Four
    {
        List<string> items = new List<string>();
        public Four()
        {
            Init();
        }

        private void Init()
        {
            InputReader ir = new InputReader("B:\\CodeStuff\\C#\\Advent\\Apps\\threeInput.txt");
            while (!ir.AtEnd())
            {
                items.Add(ir.Pop<string>());
            }
            string longestStr = "";

            for (int i = 0; i < items.Count; i++)
            {
                string first = items[i];
                for (int j = 0; j < items.Count; j++)
                {
                    if (i != j)
                    {
                        string second = items[j];
                        string common = CalcCommon(first, second);
                        if (longestStr.Length < common.Length)
                        {
                            longestStr = common;
                            Console.WriteLine(longestStr);
                        }
                    }
                }
            }
            Console.WriteLine(longestStr);
        }
        private string CalcCommon(string first, string second)
        {
            string ans = "";
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == second[i])
                {
                    ans += first[i];
                }
            }
            return ans;
        }
    }
}
