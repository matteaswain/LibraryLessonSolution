using System;

namespace LibraryLesson
{
    public class MathLib
    {
        public static int Add(int a, int b)
        {
            return a + b; 
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Mult(int a, int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            return a / b;
        }

        public static int Modulo(int a, int b)
        {
            return ((a / b) * b) - a;
                     
        }

        
    }
}
