using System;

class Program
{
    static void Main()
    {
        Random Random = new Random();
        int soBiMat = Random.Next(1, 101);
        int soLanDoan = 0;
        Console.WriteLine("Toi da nghi so tu 1 den 100. Doan thu xem! ");
        while (true)
        {
            Console.Write("Nhap so ban doan: ");
            int soDoan = int.Parse(Console.ReadLine());
            soLanDoan++;

            if (soDoan == soBiMat)
            {
                Console.WriteLine(" Chinh xac! Ban doan dung sau " + soLanDoan +" lan.");
                break;
            }
            else if (soDoan < soBiMat)
            {
                Console.WriteLine("Nho qua, thu so lon hon!");

            }
            else
            {
                Console.WriteLine("Lon qua, thu so nho hon!");
            }
        }


    }

}