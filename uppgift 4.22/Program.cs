using System;
 
    namespace uppgift4_22

{
    class program
    {
        static void Main(string[] args)
       
        
        {
            for (int i = 10; i <= 30; i++)
            {
                Console.WriteLine($"{i}");
                if (i == 30)
                    break;
            }

            for (int i = 200; i >= 180; i--)
            {
                Console.WriteLine($"{i}");
                if (i == 180)
                    break;
            }
            for (int i = 1000; i <= 1400; i=i+50)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
