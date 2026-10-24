using System;
class Program
{
    static int mauToiDa = 100;
  static int TruMau(int mau, int satThuong)
    {
        int mauConLai = mau - satThuong;
        if (mauConLai < 0)
        {
            mauConLai = 0;
        }
        return mauConLai;
       
       

    

        
    }
     
        static void Main()
        {
            Console.WriteLine(TruMau(100, 20));  // phải ra 80
            Console.WriteLine(TruMau(50, 20));   // phải ra 30
            Console.WriteLine(TruMau(30, 50));   // phải ra 0
        }
    
}