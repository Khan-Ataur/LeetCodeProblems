using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPractice
{
    public class _2011_Perform_Operation
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int K = 0;
           

            if (operations.Length > 0)
            {
                for (int i = 0; i < operations.Length; i++)
                {
                    if (operations[i]=="++X")
                    {
                        ++K;
                    }

                    if (operations[i] == "X++")
                    {
                        K++;
                    }

                    if (operations[i] == "--X")
                    {
                        --K;
                    }

                    if (operations[i] == "X--")
                    {
                        K--;
                    }
                }
            }

            return K;
        }


    }
}
