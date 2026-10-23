using System;

class Program
{
    static void InTieuDe(string tenTran)
    {
        Console.WriteLine("===== " + tenTran + " =====");
    }

    static void GioiThieu(string ten, int mau, int sucManh)
    {
        Console.WriteLine(ten + " | Mau: " + mau + " | Suc manh: " + sucManh);
    }

    static int TinhSatThuong(int sucManh, int xucXac)
    {
        int satThuong = sucManh + xucXac;
        return satThuong;
    }

    static int TanCong(string tenKeTanCong, string tenDoiThu, int mauDoiThu, int sucManh, int xucXac)
    {
        int satThuong = TinhSatThuong(sucManh, xucXac);
        int mauMoi = mauDoiThu - satThuong;
        Console.WriteLine(tenKeTanCong + " danh " + tenDoiThu + " gay " + satThuong + " sat thuong. Mau " + tenDoiThu + " con: " + mauMoi);
        return mauMoi;
    }

    static bool ConSong(int mau)
    {
        return mau > 0;
    }

    static string XepHang(int diem)
    {
        if (diem >= 300)
        {
            return "S";
        }
        else if (diem >= 200)
        {
            return "A";
        }
        else if (diem >= 100)
        {
            return "B";
        }
        else
        {
            return "C";
        }
    }

    static void Main()
    {
        InTieuDe("DAU TRUONG MINI");

        string tenA = "Hiep Si";
        int mauA = 100;
        int sucManhA = 12;

        string tenB = "Goblin";
        int mauB = 80;
        int sucManhB = 9;

        GioiThieu(tenA, mauA, sucManhA);
        GioiThieu(tenB, mauB, sucManhB);

        Random rd = new Random();
        int luot = 1;
        int diem = 0;

        while (ConSong(mauA) && ConSong(mauB))
        {
            Console.WriteLine("-- Luot " + luot + " --");

            int xucXac = rd.Next(0, 6);
            mauB = TanCong(tenA, tenB, mauB, sucManhA, xucXac);
            diem = diem + 10;

            if (ConSong(mauB))
            {
                xucXac = rd.Next(0, 6);
                mauA = TanCong(tenB, tenA, mauA, sucManhB, xucXac);
            }

            luot = luot + 1;
        }

        Console.WriteLine("===== KET THUC =====");
        if (ConSong(mauA))
        {
            Console.WriteLine(tenA + " thang!");
        }
        else
        {
            Console.WriteLine(tenB + " thang!");
        }
        Console.WriteLine("Diem cua " + tenA + ": " + diem + " - Hang " + XepHang(diem));
    }
}
