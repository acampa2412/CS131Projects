using System;

namespace CS131Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = SumOfHoursInGym(2, 2, 2, 2, 2);
            Console.WriteLine(result);
        }
        public static int SumOfHoursInGym(int Monday, int Tuesday, int Wednesday, int Thursday, int Friday)
        {
            int result = Monday + Tuesday + Wednesday + Thursday + Friday;
            return result;
        }
    }
}
