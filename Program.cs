/*using System;
using System.Threading.Tasks;
namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. tong hai so
            *//*  double a = 1.1, b = 5;
              Console.WriteLine($"Tong cua hai so {a} va {b} la : { a + b}");*//*

            //2.lap phuong so nguyen
            *//*Console.WriteLine("Nhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = n*n*n;
            Console.WriteLine($"Lap phuong cua so {n} la {sum}");*//*

            //3.thuong hai so
            *//*         Console.WriteLine("Nhap vao 2 so a, b: ");
                     double a = double.Parse(Console.ReadLine());
                     double b = double.Parse(Console.ReadLine());
                     Console.WriteLine($"Thuong cua 2 so {a} va {b}: {a/b}");*//*

            //4.in chuoi
            // a = 1, b = 't' , c = "hello", d = 2,3 , e = true
            *//* int a = 1;
             char b = 't';
             string c = "hello";
             double d = 2.3;
             bool e = true;
             string s = a.ToString() + b.ToString() + c.ToString() + d.ToString() + e.ToString();
             Console.WriteLine($"{s}");*//*

            //5.Nhập 1 số nguyên x từ bàn phím sau đó tính giá trị hàm số y = x^2 + 3x + 2
            *//*            Console.WriteLine("Nhap vao so nguyen x: ");
                        double x = int.Parse(Console.ReadLine());

                        double y = Math.Pow(x, 2) + 3 * x + 2;
                        Console.WriteLine($"Gia tri cua ham so y = {y}");*//*

            //6. Tinh AVG 4 so
            *//* Console.WriteLine("Nhap vao 4 so: ");
             int a = int.Parse(Console.ReadLine());
             int b = int.Parse(Console.ReadLine());
             int c = int.Parse(Console.ReadLine());
             int d = int.Parse(Console.ReadLine());
             double avg = (a + b + c + d) / 4;
             Console.WriteLine($"TBC cua 4 so {a}, {b}, {c}, {d} la {Math.Round(avg, 3)}");*//*

            //CS1_2_10: Viết chương trình đổi từ độ C sang độ K và độ F  1,8, sau đó thêm 32. 
            *//*Console.WriteLine("Nhap vao do C: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} do C = {a + 273.15} do K va {a * 1.8 + 32} do F");*//*

            //CS1_2_12: Viết chương trình tính diện tích và thể tích hình cầu
            *//*Console.WriteLine("Nhap vao ban kinh hinh cau: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dien tich mat cau la {Math.Round(4 * 3.14 * r * r, 2)}");
            Console.WriteLine($"Chu vi mat cau la {3.14 * r * 2}");*//*

            //CS1_2_13: Viết chương trình tính vận tốc
            *//*Console.WriteLine("Nhap vao quang duong(km): ");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao thoi gian(hour): ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine($"Van toc: {s/h}km/h, {Math.Round(s * 1000 / (h * 60 * 60), 2)}m/s, {s*1000/h}m/h");*//*

            //CS1_2_14: Viết chương trình để hoán đổi giá trị
            *//*Console.WriteLine("Nhap vao a va b: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"a va b la {a} va {b}");*//*

            //CS1_2_08: Viết chương trình tính khoảng cách từ 1 điểm đến 1 đường thẳng
            *//*Console.WriteLine("Nhap vao diem M(x, y) va he so a, b, c: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = Math.Abs(a * x + b * y + c) / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"Khoang cach cua M toi duong thang d la: {Math.Round(d, 3)}");*//*

            //CS1_2_05: Viết chương trình tính chu vi và diện tích hình tròn
            *//*Console.WriteLine("Nhap ban kinh: ");
              double r = double.Parse(Console.ReadLine());
              Console.WriteLine($"Chu vi hinh tron la: {2 * 3.14 * r}. Dien tich hinh tron la: {3.14 * r * r}");*//*

            //CS1_2_11: Viết chương trình tính ngày về hưu của 1 người
            *//* Console.WriteLine("Nhap ho ten: ");
             string hoTen = Console.ReadLine();
             Console.WriteLine("Nhap ngay sinh: ");
             DateTime ngaySinh = DateTime.Parse(Console.ReadLine());
             DateTime ngayNghiHuu = new DateTime(ngaySinh.Year + 60, ngaySinh.Month, ngaySinh.Day);
             Console.WriteLine($"Ho ten: {hoTen}");
             Console.WriteLine($"Ngay nghi huu: {ngayNghiHuu.ToShortDateString()}");*//*

            //CS01-5-01: Kiểm tra số chẵn
            *//* Console.WriteLine("Nhap vao so nguyen: ");
             int n = int.Parse(Console.ReadLine());
             Console.WriteLine(n % 2 == 0 ?"day la so chan":"day la so le");*//*

            //CS01-5-02: Bài toán xếp loại học lực
            *//*Console.WriteLine("Nhap vao diem Toan Van Anh: ");
            double t = double.Parse(Console.ReadLine());
            double v = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double avg = (t + v + a) / 3;
            Console.Write($"Diem trung binh cua hoc sinh la {Math.Round(avg,2)}. Hoc luc cua hoc sinh la ");
            if(avg <= 4)
            {
                Console.Write("Yeu");
            }
            else if(avg > 4 && avg <= 6.5)
            {
                Console.Write("TB");
            }
            else if (avg > 6.5 && avg <= 8)
            {
                Console.Write("Kha");
            }
            else if (avg > 8 && avg <= 9)
            {
                Console.Write("Gioi");
            }
            else
            {
                Console.Write("Xuat sac");
            }*//*

            //CS01-5-03: Tìm số lớn nhất trong 2 chữ số
            *//*Console.WriteLine("Nhap vao hai so: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a > b ? $"{a} lon hon {b}":$"{a} be hon {b}");*//*

            //CS01-5-04: Tìm số lớn nhất trong 3 số
            *//*Console.WriteLine("Nhap vao 3 so: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine($"{a} la so lon nhat");
            }
            else if (b > c && b > c)
            {
                Console.WriteLine($"{b} la so lon nhat");
            }
            else
            {
                Console.WriteLine($"{c} la so lon nhat");
            }*//*

            //CS01-5-05: Kiểm tra tam giác
            *//*  Tổng 3 góc của một tam giác bằng 180 độ.
-    Tam giác đều là tam giác có mỗi góc đều bằng 60 độ.
-    Tam giác cân là tam giác có hai góc ở đáy bằng nhau.
-    Tam giác vuông là tam giác có 1 góc bằng 90 độ.*/

            /*Console.WriteLine("Nhap vao 3 goc cua tam giac: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if(a + b + c != 180)
            {
                Console.WriteLine("Khong hop le!");
            }
            else if(a == 90 || c == 90 || b == 90)
            {
                Console.WriteLine("Day la tam giac vuong!");
            }
            else if (a == 60 && c == 60 && b == 60)
            {
                Console.WriteLine("Day la tam giac deu!");
            }else if(a==b || a==c || b == c)
            {
                Console.WriteLine("Day la tam giac can!");
            }
            else
            {
                Console.WriteLine("Tam giac thuong");
            }*//*

            //CS01-5-06: Kiểm tra sự tương giao giữa 2 đường thẳng
            *//*Console.WriteLine("Nhap vao he so cua d1: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao he so cua d2: ");
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            if(a1 != 0 && a != 0 )
            {
                if (a1 * a == -1)
                {
                    Console.WriteLine("d1 va d2 vuong goc");
                }
                else if(a1 != a)
                {
                    Console.WriteLine("d1 va d2 cat nhau");
                }
                else if (a1 == a && b1 != b)
                {
                    Console.WriteLine("d1 va d2 song song");
                }
                else if (a1 == a && b1 == b)
                {
                    Console.WriteLine("d1 va d2 trung nhau");
                }
            }
            else
            {
                Console.WriteLine("Khong hop le");
            }*//*

            //CS01-5-07: Kiểm tra độ cao trung bình của con người
            *//*Rất lùn: < 145cm
-    Lùn: < 150cm 
-    Bình Thường: >= 150cm và < 1m70
-    Cao:  >= 170cm và <= 180cm
-    Rất Cao: > 180cm*/
            /*Console.WriteLine("Nhap chieu cao cua 1 nguoi(cm): ");
            int height = int.Parse(Console.ReadLine());
            if(height > 0)
            {
                if (height < 145 && height > 0)
                {
                    Console.WriteLine("Rat lun");
                }
                else if(height < 150 && height >= 145)
                {
                    Console.WriteLine("Lun");
                }
                else if (height < 170 && height >= 150)
                {
                    Console.WriteLine("Binh thuong");
                }
                else if (height <= 180 && height >= 170)
                {
                    Console.WriteLine("Cao");
                }
                else
                {
                    Console.WriteLine("Rat Cao");
                }
            }
            else
            {
                Console.WriteLine("Khong hop le");
            }*//*

            //CS01-5-08: Các tháng trong mỗi mùa
            *//*Console.WriteLine("Nhap vao mot thang: ");
            int month = int.Parse(Console.ReadLine());
            if(month > 0 && month <= 12)
            {
                switch (month)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine("Day la mua xuan");
                        break;
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine("Day la mua he");
                        break;
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine("Day la mua thu");
                        break;
                    default:
                        Console.WriteLine("Day la mua dong");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Khong hop le");
            }*//*

            //CS01 - 5 - 09: Hiện thị ngày tháng năm

            *//*    Console.WriteLine("Nhap vao nam va thang: ");
                int year = int.Parse(Console.ReadLine());
                int month = int.Parse(Console.ReadLine());
                int dayOfMonth = 0;
                if(year >= 1000 && year <= 2023 && month > 0 && month <=12)
                {
                    if(year % 4 == 0)
                    {
                        if (month == 2)
                        {
                            dayOfMonth = 29;
                        }
                    }
                    switch (month)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            dayOfMonth = 31;
                            break;
                        case 2:
                            dayOfMonth = 28;
                            break;
                        default:
                            dayOfMonth = 30;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Khong hop le");
                }
                Console.WriteLine($"Cac ngay cua thang {month} nam {year} la: ");
                for (int i = 1; i <= dayOfMonth; i++)
                {
                    Console.Write($"{i}  ");
                }
    *//*
            //CS01-5-10: Kiểm tra 1 tháng có bao nhiêu ngày

            *//*Console.WriteLine("Nhap vao nam va thang: ");
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int dayOfMonth = 0;
            if (year >= 1000 && year <= 2023 && month > 0 && month <= 12)
            {
                if (year % 4 == 0)
                {
                    if (month == 2)
                    {
                        dayOfMonth = 29;
                    }
                }
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        dayOfMonth = 31;
                        break;
                    case 2:
                        dayOfMonth = 28;
                        break;
                    default:
                        dayOfMonth = 30;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Khong hop le");
            }
            Console.WriteLine($"So ngay cua thang {month} nam {year} la: {dayOfMonth}");*//*



            //CS1_5_12: Viết hàm kiểm tra tài khoản
            *//*string acc = "toila@";
            string pass = "123456";
            Console.WriteLine("Nhap tai khoan va password");
            string acccount = Console.ReadLine();
            string password = Console.ReadLine();
            if(acc == acccount && pass == password)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Fail");
            }*//*

            //CS1_5_15: Bài tập sử dụng hàm switch-case 1
            *//* Console.WriteLine("Nhap thu trong tuan: ");
             int day = int.Parse(Console.ReadLine());

                 switch (day)
                 {
                 case 2:
                     Console.WriteLine("Thu 2");
                     break;
                 case 3:
                     Console.WriteLine("Thu 3");
                     break;
                 case 4:
                     Console.WriteLine("Thu 4");
                     break;
                 case 5:
                     Console.WriteLine("Thu 5");
                     break;
                 case 6:
                     Console.WriteLine("Thu 6");
                     break;
                 case 7:
                     Console.WriteLine("Thu 7");
                     break;
                 case 8:
                     Console.WriteLine("Chu nhat");
                     break;
                     default:
                         Console.WriteLine("Khong phai thu trong tuan!");
                         break;
                 }*//*

            //CS1_5_13: Viết chương trình C# kiểm tra ký tự nhập vào có phải ký tự đặc biệt hay không

            *//*Console.WriteLine("Nhap vao mot ky tu: ");
            char c = Console.ReadLine()[0];
            if (char.IsLetterOrDigit(c))
            {
                Console.WriteLine($"{c} khong phai ky tu dac biet");
            }
            else
            {
                Console.WriteLine($"{c} la ky tu dac biet");
            }*//*

            //CS1_5_11: Viết hàm kiểm tra nguyên âm, phụ âm
            *//*string phAm = "qwrtpsdfghjklzxcvbnmQWRTPSDFGHJKLMNBVCXZ";
            string ngAm = "euioaEUIOA";
            char c = Console.ReadLine()[0];
            if (ngAm.Contains(c)){
                Console.WriteLine($"{c} la nguyen am");
            }
            else if(phAm.Contains(c))
            {
                Console.WriteLine($"{c} la phu am");
            }
            else
            {
                Console.WriteLine("Khong la gi ca");
            }*//*

            //Viết chương trình C# để đếm số chữ cái, số chữ số, số ký tự đặc biệt trong một chuỗi
            *//*int cs = 0, cc = 0, kt = 0;
            string s = "baby89**baby";
            char[] charArr = s.ToCharArray();
            foreach (char item in charArr)
            {
                if (char.IsDigit(item))
                {
                    cs++;
                }
                else if (char.IsLetter(item))
                {
                    cc++;
                }
                else
                {
                    kt++;
                }
            }
            Console.WriteLine($"{s} co {cs} chu so, {cc} chu cai va {kt} ky tu");*//*
            //CS01-6-01: In dãy số ra màn hình
            *//* for (int i = 0; i < 50; i++)
             {
                 Console.WriteLine($"{i} ");
             }*//*

            //CS01-6-02: In số chẵn trong dãy số
            *//*Console.WriteLine("Nhap so nguyen duong a:");
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 2; i <= a/2; i += 2)
            {
                if(a % i == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Tong cac uoc chan cua {a} la {sum}");*//*

            //CS01-6-03: Tìm ước số lẻ lớn nhất
            *//*Console.WriteLine("Nhap so nguyen duong a:");
            int a = int.Parse(Console.ReadLine());
            int maxle = 0;
            for (int i = 1; i <= a / 2; i += 2)
            {
                if (a % i == 0 )
                {
                    maxle = i;
                }
            }
            Console.WriteLine($"Uoc le lon nhat cua {a} la {maxle}"); *//*

            //CS01-6-05: Tính tích số chính phương
            *//*Console.WriteLine("Nhap vao so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 1;
            if (n > 50 || n < 0)
            {
                Console.WriteLine("khong hop le");
            }

            for (int i = 1; i < n; i++)
            {
                if (Math.Sqrt(i) % 1 == 0)
                {
                    sum = sum * i;
                }
            }
            Console.WriteLine($"Tich cac so chinh phuong tu 1 - n la: {sum}");*//*

            //CS01-6-09: Kiểm tra số nguyên tố

            *//*Console.WriteLine("Nhap vao so n: ");
            int n = int.Parse(Console.ReadLine());
            bool check = true;
            if(n < 2)
            {
                check = false;   
            }
            for(int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    check = false;
                    break;
                }
            }
            if(check == true)
            {
                Console.WriteLine($"{n} la so nguyen to");
            }
            else { Console.WriteLine($"{n} khong la so nguyen to"); }*//*

            //CS01-6-07: Tính tích số các số trong 1 số nguyên
            *//*Console.WriteLine("Nhap vao so n");
            int n = int.Parse(Console.ReadLine());
            double tich = 1;
            int tmp = n;
            int du = 0;
            while(tmp != 0)
            {
                du = tmp % 10;
                tich = du * tich;
                tmp /= 10;
            }
            Console.WriteLine(tich);*//*

            //CS01-6-08: Kiểm tra số giảm dần

            *//* Console.WriteLine("Nhap so nguyen duong n: ");
             int n = int.Parse(Console.ReadLine());
             int[] arr = new int[20];
             int tmp = n;
             int du = 0;
             int i = 0;
             bool check = false;
             while (tmp != 0)
             {
                 du = tmp % 10;
                 arr[i] = du;    //nhet cac so du lan luot vao mang ta co dc so dao cua n, vd 321 se thanh arr[] = {1,2,3}
                 tmp /= 10;
                 i++;
             }
             for (i = 0; i < arr.Length-1; i++)
             {
                 if (arr[i] < arr[i + 1]) //neu arr tang co nghia la n giam dan
                 {
                     check = true;
                     break;
                 }
             }
             Console.WriteLine(check);*//*

            //CS01-6-04: Kiểm tra số toàn lẻ

            *//*Console.WriteLine("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[20];
            int tmp = n;
            int du = 0;
            int i = 0;
            int length = 0;
            bool check = true;
            while (tmp != 0)
            {
                du = tmp % 10;
                arr[i] = du;    //nhet cac so du lan luot vao mang ta co dc so dao cua n
                length++;       // dem so pt
                tmp /= 10;
                i++;
            }
            for (i = 0; i < length - 1; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    check = false;
                    break;
                }
            }
            Console.WriteLine(check == true ? "So toan le":"Khong phai");*//*

            //CS1_6_13: Viết chương trình tính tích các số nguyên tố của mảng số nguyên
            *//*int count = 0;
            double tich = 1;
            bool check = true;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int item in arr )
            {
                check = true;// khoi tao lai check sau khi kiem tra xong 1 phan tu
                if (item < 2)
                {
                    check = false;
                }
                for (int i = 2; i <= item / 2; i++)
                {
                    if (item % i == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    count++;
                    tich *= item;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Mang khong co so nguyen to nao");
                
            }
            else { Console.WriteLine($"Tich cac so nguyen to trong mang la: {tich}"); }*//*

            //CS1_6_14: Vẽ tam giác số can

            *//*Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <=i; k++)
                {
                    Console.Write(k);
                }
                for (int m = i - 1; m >= 1; m--)
                {
                    Console.Write(m);
                }
                Console.WriteLine();
            }*//*

            //CS01-6-12: Liệt kê tất cả các số nguyên tố nhỏ hơn n
            *//*Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            bool check = true;
            Console.Write($"Tat ca cac so nguyen to nho hon {n} la: ");
            for (int i = 0; i < n; i++)
            {
                check = true;// khoi tao lai check sau khi kiem tra xong 1 phan tu
                if (i < 2)
                {
                    check = false;
                }
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    Console.Write($"{i} ");
                }
            }*//*

            //CS01-6-06: Kiểm tra số theo điều kiện
            *//*Console.WriteLine("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());
            int tmp = n;
            int du = 0;
            int sum = 0;
            while (tmp != 0)
            {
                du = tmp % 10;
                sum += du;
                tmp /= 10;
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum % 3 == 0 ? $"{n} chia het cho 3" : $"{n} khong chia het 3");*//*

            //CS01-6-11: Nhập số nguyên từ bàn phím
            *//*Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            while (n < 0 || n > 100)
            {
                Console.WriteLine("Nhap sai! Moi nhap lai: ");
                n = int.Parse(Console.ReadLine());
            } 
            Console.WriteLine(n);*//*

            //CS01-6-10: Tìm ước số chung lớn nhất và bội số chung nhỏ nhất
            *//* Console.WriteLine("Nhap 2 so a va b: ");
             int a = int.Parse(Console.ReadLine());
             int b = int.Parse(Console.ReadLine());
             int x = a, y = b;
             while(x != y)
             {
                 if (x > y)
                 {
                     x = x - y;
                 }
                 else
                 {
                     y = y - x;
                 }
             }
             Console.WriteLine($"UCLN cua {a} va {b} la {x}. BCNN = {(a * b)/x}");*//*

            //CS1_7_01: Viết chương trình in ra độ dài một chuỗi được nhập vào từ bàn phím
            *//*Console.WriteLine("Nhap vao chuoi:");
            string s = Console.ReadLine();
            Console.WriteLine($"DO dai chuoi la {s.Length}");*//*

            //CS1_7_04: Viết chương trình so sánh 2 chuỗi
            *//* string s = "abcdefJGFJKKJF";
             string s2 = "ABCDEFaaadd";
             if (s.CompareTo(s2) == 0)
             {
                 Console.WriteLine("hai chuoi bang nhau");
             }else if(s.CompareTo(s2) > 0)
             {
                 Console.WriteLine("Chuoi s lon hon chuoi s2");
             }
             else
             {
                 Console.WriteLine("Chuoi s2 lon hon chuoi s1");
             }*//*

            //CS1_7_05: Viết chương trình kiếm tra chuỗi 2 có chứa chuỗi 1 không
            *//*Console.WriteLine("Nhap chuoi 1: ");
            string s = Console.ReadLine();
            Console.WriteLine("Nhap chuoi 2: ");
            string s2 = Console.ReadLine();
            while(s.Length > s2.Length)
            {
                Console.WriteLine("Chuoi 1 phai ngan hon chuoi 2. Moi nhap lai: ");
                s = Console.ReadLine();
            }
            
            if (s2.Contains(s))
            {
                Console.WriteLine($"Chuoi {s} nam trong chuoi {s2}");
            }
            else
            {
                Console.WriteLine($"Chuoi {s} khong nam trong chuoi {s2}");
            }*//*

            //CS1_7_06: Viết chương trình trả về vị trí xuất hiện đầu tiên và cuối cùng của ký tự
            *//*Console.WriteLine("Nhap vao chuoi s: ");
            string s = Console.ReadLine();
            Console.WriteLine("Nhap ky tu can tim: ");
            char c = Console.ReadLine()[0];
            char[] charArr = s.ToCharArray();
          
            for (int i = 0; i < charArr.Length; i++)
            {
                if(charArr[i] == c)
                {
                    Console.WriteLine($"Ky tu {c} xuat hien lan dau tien tai vi tri {i}");
                    break;
                }
            }
            for (int i = charArr.Length - 1; i >= 0; i--)
            {
                if (charArr[i] == c)
                {
                    Console.WriteLine($"Ky tu {c} xuat hien lan cuoi tai vi tri {i}");
                    break;
                }
            }*//*

            //CS1_7_03: Viết chương trình so sánh chuỗi trong C#
            *//*Console.WriteLine("Nhap chuoi 1: ");
            string s = Console.ReadLine();
            Console.WriteLine("Nhap chuoi 2: ");
            string s2 = Console.ReadLine();
            if (string.Compare(s, s2) == 0)
            {
                Console.WriteLine("Hai chuoi giong nhau");
            }
            else 
            {
                Console.WriteLine("Hai chuoi khac nhau");
            }*//*

            //CS1_7_07: Viết chương trình kiểm tra chuỗi A có chứa chuỗi B hay không
            *//*Console.WriteLine("Nhap chuoi 1: ");
            string s = Console.ReadLine();
            Console.WriteLine("Nhap chuoi 2: ");
            string s2 = Console.ReadLine();
            if (s.Contains(s2))
            {
                Console.WriteLine("Tim thay chuoi con trong chuoi da nhap");
            }
            else
            {
                Console.WriteLine("Khong tim thay chuoi con");
            }*//*

            //CS1_7_10: Viết chương trình đếm xem trong chuỗi họ tên của minh có bao nhiêu chữ cái
            *//*Console.WriteLine("Nhap ho ten: ");
            string hoTen = Console.ReadLine();
            int count = 0;
            char[] charArr = hoTen.ToCharArray();
            foreach (char item in charArr)
            {
                if (char.IsLetter(item))
                {
                    count++;
                }
            }
            Console.WriteLine($"Chuoi {hoTen} co {count} chu cai");*//*

            //CS01-7-14: Nhập xuất ngày tháng năm
            *//*Console.WriteLine("Nhap ngay/thang/nam: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"{date.ToShortDateString()}");*//*

            //CS1_7_02: Viết chương trình thay thế một chuỗi con bằng một chuỗi con khác trong C#
            *//*string s = "Hello C#, Hello .Net, Hello HVITCLAN";
            string s2 = s.Replace("Hello", "Cheers");
            Console.WriteLine(s2);*//*

            //CS1_7_08: Kiểm tra một chuỗi nhập vào có phải là chuỗi Empty hoặc null hay không
            *//*   Console.WriteLine("Nhap vao mot chuoi: ");
               string s = Console.ReadLine();
               if (string.IsNullOrEmpty(s))
               {
                   Console.WriteLine("Chuoi null");
               }
               else
               {
                   Console.WriteLine("Chuoi khong null");
               }*//*

            //CS1_7_09: Viết chương trình tìm vị trí của lần xuất hiện cuối cùng của một ký tự trong chuỗi
            *//* Console.WriteLine("Nhap chuoi: ");
             string s = Console.ReadLine();
             Console.WriteLine("Nhap ky tu can tim: ");
             char c = Console.ReadLine()[0];
             char[] charArr = s.ToCharArray();
             for (int i = charArr.Length - 1; i >= 0 ; i--)
             {
                 if(c == charArr[i])
                 {
                     Console.WriteLine($"Ky tu {c} xuat hien lan cuoi tai vi tri {i}");
                     break;
                 }
             }*//*

            //CS1_7_11: Sắp xếp các chuỗi theo thứ tự từ điển
            *//*Console.WriteLine("Nhap vao 3 chuoi: ");
            string[] s = new string[3];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = Console.ReadLine();
            }
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i+1; j < s.Length; j++)
                {
                    if (s[i].CompareTo(s[j]) > 0)
                    {
                        string tmp = s[i];
                        s[i] = s[j];
                        s[j] = tmp;
                    }
                }
            }
            Console.WriteLine($"3 chuoi sau khi sap xep:");
            foreach (string item in s)
            {
                Console.WriteLine($"{item} ");
            }*//*

            //CS01-7-15: Tính tuổi của một người
            *//*Console.WriteLine("Nhap ngay thang nam sinh:");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Tuoi cua ban la: {2023 - date.Year}");*//*

            //CS1_7_12: Viết hàm in chuỗi đảo ngược
            *//*Đầu vào: 1 chuỗi bất kì
            Đầu ra: dạng viết hoa, viết ngược và dạng chuỗi ngược viết hoa của chuỗi ban đầu. 
            Và đếm xem, có bao nhiêu chữ cái, chữ số và kí tự đặc biệt*/

            /*Console.WriteLine("Nhap chuoi:");
            string s = Console.ReadLine();
            string sHoa = s.ToUpper();
            int cs = 0, cc = 0, kt = 0;
            char[] charArr = s.ToCharArray();
            Console.Write($"Chuoi viet hoa: {sHoa}");
            Console.WriteLine();
            Console.Write($"Chuoi viet nguoc: ");
            for (int i = charArr.Length-1; i >= 0 ; i--)
            {
                Console.Write(charArr[i]);
            }
            Console.WriteLine();
            Console.Write($"Chuoi nguoc Viet Hoa: ");
            for (int i = charArr.Length - 1; i >= 0; i--)
            {
                Console.Write(charArr[i].ToString().ToUpper());
            }

            foreach (char item in charArr)
            {
                if (char.IsDigit(item))
                {
                    cs++;
                }else if (char.IsLetter(item))
                {
                    cc++;
                }
                else
                {
                    kt++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"So chu so la {cs}, so chu cai la {cc}, so ky tu dac biet la {kt}");*/

            /*Nhập vào họ và tên ở dạng chưa chuẩn hóa, hiển thị email có dạng yourname@hvitclan.com
            Ví dụ:
            Đầu vào:  “   Nguyen    DuC TOAN    ” 
            Đầu ra: nguyenductoan@hvitclan.com*/

            /*string s = "   Nguyen    DuC TOAN   ";
            string news = s.Trim().Replace(" ","").ToLower();
            string email = string.Concat(news, "@hvitclan.com");
            Console.WriteLine(email);*//*
        }
    }
}
*/