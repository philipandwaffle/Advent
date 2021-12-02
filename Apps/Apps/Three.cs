using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps
{
    class Three
    {
        int has2 = 0;
        int has3 = 0;
        public Three()
        {
            Init();
        }

        private void Init()
        {
            InputReader ir = new InputReader("B:\\CodeStuff\\C#\\Advent\\Apps\\threeInput.txt");
            while (!ir.AtEnd())
            {
                string s = ir.Pop<string>();
                Dictionary<char, int> charCounts = new Dictionary<char, int>();
                foreach (char c in s)
                {
                    if (!charCounts.ContainsKey(c))
                    {
                        charCounts.Add(c, 1);
                    }
                    else
                    {
                        charCounts[c]++;
                    }
                }
                if (charCounts.ContainsValue(2))
                {
                    has2++;
                }
                if (charCounts.ContainsValue(3))
                {
                    has3++;
                }
            }
            Console.WriteLine(has2 * has3);
        }
    }
}
