using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMethodLab

{
    public static class GetDiceRoll
    {
       static Random rand = new Random(); // only make one for dice example
        public static int DiceRoll()
        {

                int myrandomnum1 = rand.Next(1, 7);
                return myrandomnum1;        
            
        }
    }
    public static class GetDiceComboName
    {
        static string? DieResultName;
        public static string DiceComboName(int Die1Num, int Die2Num)
        {
            if (Die1Num == 1 && Die2Num == 1)
            {
                DieResultName = "Snake Eyes";
                return DieResultName;
            }
            else if ((Die1Num == 1 && Die2Num== 2) || (Die1Num == 2 && Die2Num == 1))
                    {
                DieResultName = "Ace Duece";
                return DieResultName;
            }
            else if (Die1Num == 6 && Die2Num == 6)
            {
                DieResultName = "Box Cars";
                return DieResultName;
            }

            return string.Empty;
           
        }
    }
    public static class GetDiceTotalName
    {
        static string? DieResultTotalName;
        public static string DiceTotalName(int Die1Num, int Die2Num)
        {
            if (Die1Num + Die2Num == 7 || Die1Num + Die2Num == 11)
            {
                DieResultTotalName = "Win";
                return DieResultTotalName;
            }
            else if (Die1Num + Die2Num == 2 || Die1Num + Die2Num == 3 || Die1Num + Die2Num == 12)
            {
                DieResultTotalName = "Craps";
                return DieResultTotalName;
            }
            return string.Empty;

        }
    }
} 