using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {
       Random rd = new Random();
       int sobimat = rd.Next(1, 101);
       int solandoan =0;

       while (true)
        {
            Console.WriteLine("Doan mot so tu 1 den 100");
            int doan = int.Parse(Console.ReadLine());
            solandoan++;
            if (doan == sobimat)
            {
                Console.WriteLine(" ban da doan dung roi" + solandoan + "so lan ban doan" );
                break;

            }
            else if(solandoan > sobimat )
            {
                Console.WriteLine("so lon qua nho hon");

            }
            else
            {
                Console.WriteLine("so nho qua lon hon");
            }
        }

    }

}