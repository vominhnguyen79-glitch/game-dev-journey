using System;
class Program
{
    static void Main()
    { 
        Console.Write("Nhap diem toan: ");
        double toan = double.Parse(Console.ReadLine());

        Console.Write("Nhap diem ly: ");
        double ly = double.Parse(Console.ReadLine());

        Console.Write("Nhap diem hoa: ");
        double hoa = double.Parse(Console.ReadLine());
        
        double trungbinh = ( toan + ly + hoa) / 3;
        Console.WriteLine("Diem toan trung binh: " + trungbinh);

           }
    
}