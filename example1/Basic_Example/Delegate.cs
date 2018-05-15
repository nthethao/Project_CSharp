//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace Basic_Example
//{
//    class Delegate
//    {
//        static FileStream fs;
//        static StreamWriter sm;
//        public delegate void printString(string s);
//        public static void WriteToScreen(string str){
//            Console.WriteLine("chuoi la : {0}",str);
//        }
//        public static void WriteToFile(string s){
//            fs =  new FileStream("c:\\temp\message.txt",
//                FileMode.Append,FileAccess.Write);
//            sm = new StreamWriter(fs);
//            sm.WriteLine(s);
//            sm.Flush();
//            sm.Close();
//            fs.Close();

    
//    }
//        public static void sendString(printString ps){
//        ps("hoc C#");
//        }
//        static void Main(string[]args){
//        Console .WriteLine("vi du minh hoa");

//            printString ps1=new printString(WriteToScreen);
//printString ps2=new printString(WriteToFile);
//            sendString(ps1);
//            sendString(ps2);

//        }


//    }
//}
