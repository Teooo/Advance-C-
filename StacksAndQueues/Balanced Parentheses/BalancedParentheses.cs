using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main()
        {
            string s = Console.ReadLine();
            bool isBalanced = true;

            if (s.Length % 2 != 0)
            {
                isBalanced = false;
            }

            Stack<char> left = new Stack<char>();
            Queue<char> right = new Queue<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '[' || s[i] == '(' || s[i] == '{')
                {
                    left.Push(s[i]);
                }
                else if (s[i] == ']' || s[i] == ')' || s[i] == '}')
                {
                    right.Enqueue(s[i]);
                }
            }

            if (left.Count == 0 || right.Count == 0)
            {
                isBalanced = false;
            }

            while (left.Count > 0)
            {
                switch (left.Pop())
                {
                    case '{':
                    {
                        if (right.Dequeue() != '}')
                        {
                            isBalanced = false;
                        }
                    }
                        break;
                    case '(':
                        {
                            if (right.Dequeue() != ')')
                            {
                                isBalanced = false;
                            }
                        }
                        break;
                    case '[':
                        {
                            if (right.Dequeue() != ']')
                            {
                                isBalanced = false;
                            }
                        }
                        break;
                }
            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
