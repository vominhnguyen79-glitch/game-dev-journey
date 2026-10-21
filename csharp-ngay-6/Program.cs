using System;
using System.ComponentModel.DataAnnotations;
class Program
{
    static void Main()
    {
        int [] diem ={8, 7, 9, 4, 5, 10};
       int max = diem [0];
       for (int i = 1; i < diem.Length; i++)
        {
            if ( diem [i] > max)
            {
                max = diem [i];
            }
            
        }
        Console.WriteLine("MAX =" + max);


} 
}