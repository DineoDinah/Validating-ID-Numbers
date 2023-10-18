using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validating_ID_Numbers
{
    internal class Program
    {
     

        static bool checkLuhn(String IDNumber)
        {
            int nDigits = IDNumber.Length;

            int nSum = 0;
            bool isSecond = false;
            for (int i = nDigits - 1; i >= 0; i--)
            {

                int d = IDNumber[i] - '0';

                if (isSecond == true)
                    d = d * 2;

                nSum += d / 10;
                nSum += d % 10;

                isSecond = !isSecond;
            }
            return (nSum % 10 == 0);
        }

        
        static public void Main()
        {
            String IDNumber = "8702265212078";
            if (checkLuhn(IDNumber))
                Console.WriteLine("This is a valid IDNumber");
            else
                Console.WriteLine("This is not a IDNumber");

        }
    

    }
}
