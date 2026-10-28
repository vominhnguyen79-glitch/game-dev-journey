using System;
class Program
{
    static int TruMau(int mau, int satThuong)
    {
        int mauConLai = mau - satThuong;
        if (mauConLai < 0)
        {
            mauConLai = 0;
        }
        return mauConLai;

    }
    static string GoiY(int doan, int sobimat)
    {
        if (doan == sobimat)
        {
            return "ban doan dung roi";
        }
        else if (doan > sobimat)
        {
         return "lon qua, nho hon di";   
        }
        else
        {
            return "nho qua, so lon hon";
        }
    }
    static void Main()
    {
        Console.WriteLine("Nhap ten nhan vat");
        string ten = Console.ReadLine();
        Console.WriteLine("Nhap mau hien tai");
        int mau = int.Parse(Console.ReadLine());
        Console.WriteLine(ten +"| Mau" + mau + "/100");
        Console.WriteLine($"{ten} | Mau: {mau}/100");

    }

}