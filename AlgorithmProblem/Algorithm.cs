using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    public class Algorithm
    {
        public int Binary(string[] arr, int start, int end, string key)
        {
            while (start <= end)
            {
                int Midvalue = (start + end) / 2;
                if (key.CompareTo(arr[Midvalue]) == 0)
                {
                    return Midvalue;
                }
                else if (key.CompareTo(arr[Midvalue]) > 0)
                {
                    start=Midvalue+1;
                }
                else
                {
                    end=Midvalue-1;
                }

            }
            return -1;
        }
    }
}
