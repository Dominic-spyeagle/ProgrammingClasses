using System;
using System.Collections.Generic;
using System.Text;

namespace BasicMethods
{
    public static class MathsUtilities
    {
        public static double SolveLinerEquation(double a, double b)
        {
            return a == 0 ? 0 : -b / a;//important stuff'?'
            //if (a == 0)

            //    return 0;

            //return -b / a;
        }
        public static int GetBiggerNumber(int a, int b)
        {
            return a > b ? a : b;

            //return a;
            //return b;
        }
            public static int GCD(int a, int b)
            {
                while (a != b)
                {
                    if (a > b)
                        a = a - b;
                    else b -= a;
                }
                return a;
            }
        public static bool IsPrime(int a)

        {  if (a < 2)
                return false;
            for (int i=2; i <a ; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;


        }
        }
    }

