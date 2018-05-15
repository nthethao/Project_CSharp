using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;

namespace CompressionTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inputDir = "c:/temp/inputdir";
            //string zipPath = "c:/temp/data.zip";
            //string extractPath = "c:/temp/outputdir";
            //ZipFile.CreateFromDirectory(inputDir, zipPath);
            //ZipFile.ExtractToDirectory(zipPath, extractPath);
            //Console.WriteLine("finish");
            //Console.ReadKey();

            //string zipPath = "c:/temp/input.zip";
            //using (ZipArchive archive = ZipFile.OpenRead(zipPath)) { 
            //foreach(ZipArchiveEntry entry in archive.Entries){
            //    Console.WriteLine("Entry:");
            //    Console.WriteLine("Name= "+ entry.Name);
            //    Console.WriteLine("fullname: "+ entry.FullName);
            //}
            //}
            //Console.Read();

            string zipPath = "c:/temp/input.zip";
            string extractPath = "c:/temp/outputdir";
            if (!Directory.Exists(extractPath))
            {
                System.IO.Directory.CreateDirectory(extractPath);
            }

            using(ZipArchive archive =  ZipFile.OpenRead(zipPath)){

                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    Console.WriteLine("Found: " + entry.FullName);

                    // Tìm kiếm các Entry có đuôi .docx
                    if (entry.FullName.EndsWith("message.txt", StringComparison.OrdinalIgnoreCase))
                    {
                        // Ví dụ: documents/Dotnet.docx
                        Console.WriteLine(" - Extract entry: " + entry.FullName);

                        // C:/test/extract/documents/Dotnet.docx  ...
                        string entryOuputPath = Path.Combine(extractPath, entry.FullName);

                        Console.WriteLine(" - Entry Ouput Path: " + entryOuputPath);

                        FileInfo fileInfo = new FileInfo(entryOuputPath);

                        // Đảm bảo rằng thưc mục chứa file này tồn tại.
                        // Ví dụ: C:/test/extract/documents
                        fileInfo.Directory.Create();

                        // Ghi đè (overwrite) file cũ nếu nó đã tồn tại.
                        entry.ExtractToFile(entryOuputPath, true);
                    }
                }


    }
            Console.ReadLine();
            }


    }
}
