/*Nhập vào họ và tên ở dạng chưa chuẩn hóa, hiển thị email có dạng yourname@hvitclan.com
            Ví dụ:
            Đầu vào:  “   Nguyen    DuC TOAN    ” 
            Đầu ra: nguyenductoan@hvitclan.com*/

            string s = "   Nguyen    DuC TOAN   ";
            string news = s.Trim().Replace(" ","").ToLower();
            string email = string.Concat(news, "@hvitclan.com");
            Console.WriteLine(email);
