using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine($"[{String.Join(", ", A)}] -> [{String.Join(", ", Solution([3, 8, 9, 7, 6], 3))}]");
        }

        public static int[] Solution(int[] A, int K)
        {
            int actualShifts = (A.Length != 0) ? K % A.Length : 0;
            if (A.Length < 2 || actualShifts == 0)
            {
                return A;
            }

            int[] shiftedA = new int[A.Length];
            Array.Copy(A, A.Length - actualShifts, shiftedA, 0, actualShifts);
            Array.Copy(A, 0, shiftedA, actualShifts, A.Length - actualShifts);

            return shiftedA;
        }
    }
}
