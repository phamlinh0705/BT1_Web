using System;
using System.Text;
using FunnyLib;

class Program
{
    static void Main(string[] args)
    {
        // Sửa lỗi hiển thị tiếng Việt trong console
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("=== Funny Console App ===");
        Console.Write("Nhập tên của bạn: ");
        string name = Console.ReadLine();
        Console.Write("Nhập số may mắn của bạn: ");
        int number = Convert.ToInt32(Console.ReadLine());

        PersonalFunny pf = new PersonalFunny(name, number);
        string result = pf.GenerateMessage();

        Console.WriteLine("Kết quả: " + result);
        Console.WriteLine("Nhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }
}
