using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CheckKieNThuc_220823
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            string[] DanhSachTenCheck = {"Porter Ross", "Camila Mccoy", "Josiah O'donnell", "Alexus Daugherty", "Aracely Knox",
                "Reginald Willis", "Dillon Acevedo", "Evelyn Larsen", "Ean Drake", "Jessie Ochoa", "Kyra Howe",
                "Ace Moyer", "Jermaine Conway", "Haylee Trevino", "Alice Lawson", "Janiah Davies", "Zaiden Leblanc"
                , "Efrain Boyd", "Litzy Wilson", "Lewis Dennis"};


            // tách chuỗi bằng splip => thành 2 chuỗi => rồi lấy chữ cái đầu tiên của chuỗi thứ 2 là key
            // nhóm theo Key 
            var FirstName = DanhSachTenCheck.GroupBy(x => x.Split(' ')[1][0]).OrderBy(x => x.Key);

            foreach (var items in FirstName)
            {

                Console.WriteLine(items.Key);
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
            //-----------------------Bài 2 -----------------------------

            Console.WriteLine("Nhập input: ");
            string chuoidecheck = Console.ReadLine();
            /// tách mảng 
            char[] arr = chuoidecheck.ToCharArray();
            List<string> danhSachTenHopLe = DanhSachTenCheck.ToList();


                for (int i = 0; i < arr.Length; i++)
                {
                
                int sl = arr.Count(x => x == arr[i]);
                   danhSachTenHopLe = FindNameValidforElement(arr[i].ToString(),sl,danhSachTenHopLe);
                
                }
            

            foreach (var item in danhSachTenHopLe)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// hàm này là hàm để tìm kiếm danh sách tên hợp lệ với từng kí tự trong chuỗi cần check nhập vào
        /// </summary>
        /// <param name="kiTuCheck"> là 1 phần tử của chuỗi cần check </param>
        /// <param name="soLuongKiTuXuatHien"> là số lượng xuất hiện của kiTuCheck trong chuỗi check </param>
        /// <param name="DanhSachTenCanCheck">Là danh sách tên hợp lệ sau mỗi lần chạy hàm này </param>
        /// <returns></returns>
        static List<string> FindNameValidforElement(string kiTuCheck,int soLuongKiTuXuatHien,List<string> DanhSachTenCanCheck)
        {
           
            
           List<string> danhSachTenHopLe = new List<string>();  
          
            foreach (var item in DanhSachTenCanCheck)
            {
                int count = 0;
                if (item.Contains(kiTuCheck))
                {
                    count = item.ToArray().Count(x => x.ToString() == kiTuCheck);
                }
                if (count >= soLuongKiTuXuatHien)
                {
                    danhSachTenHopLe.Add(item);
                }
            }
            return danhSachTenHopLe;
        }
        
    }
}
