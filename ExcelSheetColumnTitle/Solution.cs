using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSheetColumnTitle
{
    class Solution
    {
        private enum Character { A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z };
        public static string ConvertToTitle(int n)
        {
            Character pos;

            var charStack = new Stack<Character>();

            while (n >= 1)
            {
                var mod = n % 26;
                if(mod == 0)
                {
                    charStack.Push(Character.Z);
                    n = n / 26 - 1;
                    continue;
                }
                if (n <= 26)
                {
                    pos = (Character)Enum.GetValues(typeof(Character)).GetValue(n - 1);
                    charStack.Push(pos);
                    break;
                }
                else pos = (Character)Enum.GetValues(typeof(Character)).GetValue(mod - 1);

                charStack.Push(pos);
                n = n / 26;

            }

            var result = new StringBuilder(); ;
            while (charStack.Count > 0)
            {
                result = result.Append(charStack.Pop());
            }

            return result.ToString();
        }

    }
}
