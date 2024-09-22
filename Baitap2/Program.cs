using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai 1
            //Console.Write("Nhap so nguyen duong a: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Nhap so nguyen duong b: ");
            //int b = int.Parse(Console.ReadLine());

            //int tong = a + b;
            //int hieu = a - b;
            //int tich = a * b;
            //double thuong = (double)a / b;

            //Console.WriteLine("Tong cua {0} và {1} là: {2}", a, b, tong);
            //Console.WriteLine("Hieu cua {0} và {1} là: {2}", a, b, hieu);
            //Console.WriteLine("Tich cua {0} và {1} là: {2}", a, b, tich);
            //Console.WriteLine("Thuong cua {0} và {1} là: {2}", a, b, thuong);
            //Console.ReadKey();

            // Bai 2
            //Console.Write("Chieu dai hinh chu nhat: ");
            //double chieuDai = double.Parse(Console.ReadLine());

            //Console.Write("Chieu rong hinh chu nhat: ");
            //double chieuRong = double.Parse(Console.ReadLine());

            //double dienTich = chieuDai * chieuRong;
            //double chuVi = 2 * (chieuDai + chieuRong);

            //Console.WriteLine("Dien tich hinh chu nhat: {0}", dienTich);
            //Console.WriteLine("Chu vi hinh chu nhat: {0}", chuVi);
            //Console.ReadKey();

            // Bai 3
            //Console.Write("Duong kinh hinh tron: ");
            //double duongKinh = double.Parse(Console.ReadLine());

            //double banKinh = duongKinh / 2;
            //double chuVi = 2 * Math.PI * banKinh;
            //double dienTich = Math.PI * Math.Pow(banKinh, 2);

            //Console.WriteLine("Ban kinh hinh tron: {0}", banKinh);
            //Console.WriteLine("Chu vi hinh tron: {0}", chuVi);
            //Console.WriteLine("Dien tich hinh tron: {0}", dienTich);
            //Console.ReadKey();

            // Bai 4
            //Console.Write("Ho & ten hoc sinh: ");
            //string hoTen = Console.ReadLine();
            //Console.Write("Nhap lop: ");
            //string lop = Console.ReadLine();

            //Console.Write("Diem trung binh HKI: ");
            //double diemHKI = double.Parse(Console.ReadLine());
            //Console.Write("Diem trung binh HKII: ");
            //double diemHKII = double.Parse(Console.ReadLine());

            //double diemTrungBinhCaNam = (diemHKI + diemHKII * 2) / 3;

            //Console.WriteLine("\nThong tin hoc sinh:");
            //Console.WriteLine("Ho va ten: {0}", hoTen);
            //Console.WriteLine("Lop: {0}", lop);
            //Console.WriteLine("Diem trung binh HKI: {0}", diemHKI);
            //Console.WriteLine("Diem trung bình HKII: {0}", diemHKII);
            //Console.WriteLine("Diem trung binh ca nam: {0}", diemTrungBinhCaNam);
            //Console.ReadKey();

            // Bai 5
            //Console.WriteLine("Nhap thong tin cho nhan vien 1:");
            //Console.Write("Nhap ho ten: ");
            //string hoTen1 = Console.ReadLine();
            //Console.Write("Nhap gioi tinh: ");
            //string gioiTinh1 = Console.ReadLine();
            //Console.Write("Nhap ngay sinh: ");
            //string ngaySinh1 = Console.ReadLine();

            //Console.Write("Nhap he so luong: ");
            //double heSoLuong1 = double.Parse(Console.ReadLine());
            //Console.Write("Nhap luong co ban: ");
            //double luongCoBan1 = double.Parse(Console.ReadLine());

            //Console.Write("Nhap so nam lam viec: ");
            //int soNamLamViec1 = int.Parse(Console.ReadLine());
            //double phuCap1 = soNamLamViec1 > 5 ? luongCoBan1 / 2 : 0;

            //Console.WriteLine("\nNhap thong tin cho nhan vien 2:");
            //Console.Write("Nhap ho ten: ");
            //string hoTen2 = Console.ReadLine();
            //Console.Write("Nhap gioi tinh: ");
            //string gioiTinh2 = Console.ReadLine();
            //Console.Write("Nhap ngay sinh: ");
            //string ngaySinh2 = Console.ReadLine();

            //Console.Write("Nhap he so luong: ");
            //double heSoLuong2 = double.Parse(Console.ReadLine());
            //Console.Write("Nhap luong co ban: ");
            //double luongCoBan2 = double.Parse(Console.ReadLine());

            //Console.Write("Nhap so nam lam viec: ");
            //int soNamLamViec2 = int.Parse(Console.ReadLine());
            //double phuCap2 = soNamLamViec2 > 5 ? luongCoBan2 / 2 : 0;

            //Console.WriteLine("\nThong tin nhan vien 1:");
            //Console.WriteLine("Ho ten: {0}", hoTen1);
            //Console.WriteLine("Gioi tinh: {0}", gioiTinh1);
            //Console.WriteLine("Ngay sinh: {0}", ngaySinh1);
            //Console.WriteLine("He so luong: {0}", heSoLuong1);
            //Console.WriteLine("Luong co ban: {0}", luongCoBan1);
            //Console.WriteLine("So nam lam viec: {0}", soNamLamViec1);
            //Console.WriteLine("Phu cap nhan vien: {0}", phuCap1);

            //Console.WriteLine("\nThong tin nhan vien 2:");
            //Console.WriteLine("Ho ten: {0}", hoTen2);
            //Console.WriteLine("Gioi tinh: {0}", gioiTinh2);
            //Console.WriteLine("Ngay sinh: {0}", ngaySinh2);
            //Console.WriteLine("He so luong: {0}", heSoLuong2);
            //Console.WriteLine("Luong co ban: {0}", luongCoBan2);
            //Console.WriteLine("So nam lam viec: {0}", soNamLamViec2);
            //Console.WriteLine("Phu cap nhan vien: {0}", phuCap2);
            //Console.ReadKey();

            // Bai 6
            Console.Write("Nhap ngay (dd): ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Nhap thang (MM): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Nhap nam (yyyy): ");
            int year = int.Parse(Console.ReadLine());

            {
                DateTime inputDate = new DateTime(year, month, day);

                DateTime yesterday = inputDate.AddDays(-1);
                DateTime today = inputDate;
                DateTime tomorrow = inputDate.AddDays(1);

                string format = "dd/MM/yyyy";
                CultureInfo provider = CultureInfo.InvariantCulture;

                Console.WriteLine($"Ngay hom qua: {yesterday.ToString(format, provider)}");
                Console.WriteLine($"Ngày hôm nay: {today.ToString(format, provider)}");
                Console.WriteLine($"Ngay mai: {tomorrow.ToString(format, provider)}");
                Console.ReadKey();
            }
        }
    }
}
