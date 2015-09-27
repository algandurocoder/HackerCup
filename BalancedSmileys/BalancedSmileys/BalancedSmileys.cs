using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedSmileys
{
    public class BalancedSmileys
    {
        public static Boolean AreSmileysBalanced(string inputString)
        {
            
            Int32 openParenthesis = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '(')
                {
                    if (i == 0 || inputString[i - 1] != ':')
                        openParenthesis++;
                }
                else if (inputString[i] == ')')
                {        
                    if (i == 0 || inputString[i - 1] != ':')
                        openParenthesis--;
                    if(openParenthesis < 0)
                        break;
                }
            }

            return openParenthesis == 0;
                
        }

    }
}
