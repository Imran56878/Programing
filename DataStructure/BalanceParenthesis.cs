using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class BalanceParenthesis
    {
        public void Check()
        {
            StackOperation<char> l1 = new StackOperation<char>();
            string str = "(5+6)*(7+8)/(4+3)*(5+6)*(7+8)/(4+3)";
            int length = str.Length;
            char[] arr = str.ToCharArray();
            for (int i=0;i<length;i++)
            {
                if (arr[i]=='(')
                {
                    l1.push('(');
                }
                else if (arr[i] == ')')
                {     
                    if(l1.isEmpty() == false)
                    {
                        l1.pop();
                    }
                    else { l1.push(')'); }
                   
                }
            }
            if (l1.isEmpty()==true )
            {
                Console.WriteLine(" Parenthesis in expression is balanced ");
            }
            else Console.WriteLine(" Parenthesis in expression is not  balanced ");
        }
    }
}
