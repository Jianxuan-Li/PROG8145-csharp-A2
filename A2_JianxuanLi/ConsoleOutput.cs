using System;

namespace A2_JianxuanLi
{
    public class ConsoleOutput
    {
        public static void Alert(string msg, bool inline = false)
        {
            if (!inline)
                Console.WriteLine(" " + msg);
            else
                Console.Write(" " + msg);
        }
    }
}