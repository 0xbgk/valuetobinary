using System;

namespace valuetobinary
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int sayi = 1;
                Console.Write("Enter Value: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                string def;
                def = "";
                while (sayi > 0)
                {
                    if (sayi % 2 == 0)
                    {
                        def += "0";
                    }
                    else if (sayi % 2 == 1)
                    {
                        def += "1";
                    }
                    sayi = sayi / 2;
                }

                for (int i = def.Length - 1; i >= 0; i--)
                {
                    Console.Write(def[i]);
                }
                Console.WriteLine();
            } while (true);


            //string def;
            //int sayi;
            //for (int j = 1; j <= 1000; j++)
            //{
            //    sayi = j;
            //    def = "";
            //    while (sayi >= 0)
            //    {
            //        if (sayi % 2 == 0)
            //        {
            //            def += "0";
            //        }
            //        else if (sayi % 2 == 1)
            //        {
            //            def += "1";
            //        }
            //        sayi = sayi / 2;
            //        if (sayi == 0)
            //        {
            //            break;
            //        }
            //    }
            //    Console.Write(j+" = ");
            //    for (int i = def.Length-1; i >= 0; i--)
            //    {                    
            //        Console.Write(def[i]);
            //    }
            //    Console.WriteLine();
            //}
            Console.Read();
        }
    }
}
