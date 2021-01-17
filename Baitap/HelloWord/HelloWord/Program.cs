using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Nhap Ten Nguoi Dung");
            Console.WriteLine("Chao mung:" + Console.ReadLine() + " den voi mon hoc LTQL");// in ra man hinh
            Console.WriteLine("Giai phuong trinh bac nhat ax + b =0:");
            Console.WriteLine("Nhap he so a:");
            string temp1 = Console.ReadLine();
            int a = int.Parse(temp1);
            Console.WriteLine("Nhap he so b:");
            string temp2 = Console.ReadLine();
            int b = int.Parse(temp2);
            int x = -b / a;
            Console.WriteLine("Phuong trinh:" + a + "x +" + b + " =0 co nghiem la: x = " + x);
        }
    }
}
