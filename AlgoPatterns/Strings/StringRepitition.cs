using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProject.Strings
{
    internal class StringRepitition
    {
        public void Repitition(string str)
        {
            string[] r = str.Split(' ');
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            for (int i = 0; i < r.Length; i++)
            {
                if (keyValuePairs.ContainsKey(r[i]))
                {
                    keyValuePairs[r[i]] += 1;
                }
                else
                {
                    keyValuePairs[r[i]] = 1;
                }
            }
            for (int i = 0; i < r.Length; i++)
            {
                if(keyValuePairs[r[i]]>1)
                {
                    Console.Write(r[i]);
                    break;
                }
            }
        }
    }
}
