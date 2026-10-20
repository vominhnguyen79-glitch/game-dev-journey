using System;
class Program
{
    static void Main()
    {
        int [] diem ={8, 7, 9, 4, 5};
       int tong = 0;
       for (int i = 0; i < diem.Length;i++)
        {
            tong = tong + diem[i];
            Console.WriteLine("tong diem la" + tong );
        }


} 
}