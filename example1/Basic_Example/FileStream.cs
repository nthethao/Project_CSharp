////using System;
////using System.IO;

////namespace VietJackCsharp
////{
////    class TestCsharp
////    {
////        static void Main(string[] args)
////        {
////            Console.WriteLine("Vi du minh hoa File I/O trong C#");
////            Console.WriteLine("---------------------------------");

////            FileStream F = new FileStream("binary.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
////            for (int i = 1; i <= 20; i++)
////            {
////                F.WriteByte((byte)i);
////            }

////            F.Position = 0;
////            for (int i = 0; i <= 20; i++)
////            {
////                Console.Write(F.ReadByte() + " ");
////            }
////            F.Close();

////            Console.ReadKey();
////        }
////    }
////}







//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace CSharpStreamsTutorial
//{
//    class FileStreamFileModeDemo
//    {
//        public static void Main(string[] args)
//        {
//            String path = @"C:\temp\MyTest.txt";

//            if (!File.Exists(path))
//            {
//                Console.WriteLine("File " + path + " does not exists!");

//                // Đảm bảo rằng thư mục cha tồn tại.
//                Directory.CreateDirectory(@"C:\temp");
//            }

//            // Tạo ra một FileStream để ghi dữ liệu.
//            // (FileMode.Append: Mở file ra để ghi tiếp vào phía cuối của file,
//            //  nếu file không tồn tại sẽ tạo mới). 
//            using (FileStream writeFileStream = new FileStream(path, FileMode.Append))
//            {
//                string s = "\nHello every body!";

//                // Chuyển một chuỗi thành mảng các byte theo mã hóa UTF8.
//                byte[] bytes = Encoding.UTF8.GetBytes(s);

//                // Ghi các byte xuống file.
//                writeFileStream.Write(bytes, 0, bytes.Length);
//            }
//            Console.WriteLine("Finish!");

//            Console.ReadLine();
//        }

//    }
//}