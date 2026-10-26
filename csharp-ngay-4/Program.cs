using System;
using System.ComponentModel;

class Program
{
    static string GoiY(int doan, int sobimat)
    {
        if ( doan == sobimat )
        {
            return (" dung roi");
            

        }
        else if ( doan > sobimat)
        {
          return(" so lon qua, nho hon di");
        }
        else
        {
           return(" so nho qua, lon hon di");
        }
    }

   static void Main()
{
    Random rd = new Random();
    int sobimat = rd.Next(1, 101);
    int solandoan = 0;
    bool daTrung = false;

    while (solandoan < 7)
    {
        Console.WriteLine("Doan mot so tu 1 den 100");
        int doan = int.Parse(Console.ReadLine());
        solandoan++;
        if (doan == sobimat)
        {
            Console.WriteLine(" ban da doan dung roi  " + solandoan + "so lan ban doan");
            daTrung = true;
            break;
        }
        string goiY = GoiY(doan, sobimat);
        Console.WriteLine(goiY);
    }
    if (daTrung == false)
    {
        Console.WriteLine("Thua roi!");
    }
}


}