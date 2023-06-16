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
