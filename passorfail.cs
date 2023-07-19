using System;
namespace passfail
{
    class passFail
    {
        public static void Main(string[] args)
        {
            int m1 = 60, m2 = 32, m3 = 50;
            if((m1>=50)&&(m2>=50)&&(m3>=50))
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("fail");
            }
        }
    }
}