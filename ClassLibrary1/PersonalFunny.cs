using System;

namespace FunnyLib
{
    public class PersonalFunny
    {
        public string Name { get; set; }
        public int LuckyNumber { get; set; }

        public PersonalFunny(string name, int luckyNumber)
        {
            this.Name = name;
            this.LuckyNumber = luckyNumber;
        }

        public string GenerateMessage()
        {
            string[] jokes = {
                "Cho Mình Xin 10k đi ",
                "Nhìn Cái Giề ",
                "Ra  Dại Luôn ",
                "Đi Chơi Thôi Bạn Ơi ",
                "Năm Nay Sẽ Lấy Chồng ",
                "Đọc Stk Bạn Chuyển Cho 10k"
             
            };

            int index = LuckyNumber % jokes.Length;
            return $"Xin chào {Name}, số may mắn của bạn là {LuckyNumber}. " +
                   $"{jokes[index]} (Nhà đầu Tư: Phạm Khắc Linh)";
        }
    }
}
