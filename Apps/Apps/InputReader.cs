using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Apps
{
    class InputReader
    {
        StreamReader sr;
        
        public InputReader(string path)
        {
            this.sr = new StreamReader(path);
        }

        public T Pop<T>()
        {
            var val = sr.ReadLine();
            return (T)Convert.ChangeType(val, typeof(T));
        }

        public bool AtEnd()
        {
            return sr.EndOfStream;
        }
    }
}
