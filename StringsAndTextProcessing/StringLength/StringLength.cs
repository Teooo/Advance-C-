using System;


namespace StringLength
{
    class StringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (input.Length > 20)
            {
                Console.WriteLine(input.Substring(0, 20).PadRight(20, '*'));
            }
            else
            {
                Console.WriteLine(input.PadRight(20, '*'));
            }
           
        }
    }
}
