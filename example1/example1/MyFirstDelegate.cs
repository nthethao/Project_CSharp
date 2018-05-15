using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace CSharpDelegatesTutorial
{
    //class MyFirstDelegate
    //{
    //    //// Định nghĩa ra một delegate
    //    //// đại diện cho các hàm có kiểu (int, int) -> (int)
    //    //delegate int IntIntToInt(int a, int b);
 
 
 
    //    //public static void Main(string[] args)
    //    //{
    //    //    // Tạo một đối tượng delegate. 
    //    //    // Truyền (pass) vào tham số là một hàm có cùng kiểu hàm với delegate.
    //    //    IntIntToInt iiToInt = new IntIntToInt(MathUtils.sum);
 
    //    //    // Khi bạn thực thi một delegate.
    //    //    // Nó sẽ gọi hàm (hoặc phương thức) mà nó đại diện.
    //    //    int value = iiToInt(10, 20); // 30
 
    //    //    Console.WriteLine("Value = {0}", value);
 
    //    //    // Gán giá trị khác cho delegate.
    //    //    iiToInt = new IntIntToInt(MathUtils.multiple);
 
    //    //    value = iiToInt(10, 20); // 200
 
    //    //    Console.WriteLine("Value = {0}", value);
 
    //    //    Console.Read();
 
    //    //}
 
 
    //}


    class MyApplication
    {
        private Button openButton;
        private Button saveButton;
        private string fileName;

        // Mô phỏng một ứng dụng và có các Button.
        public MyApplication()
        {
            // Thêm 1 Button vào giao diện.
            this.openButton = new Button("Open File");

            // Thêm 1 Button vào giao diện.
            this.saveButton = new Button("Save File");

            // Thêm một phương thức vào sự kiện của button 'Open Button'.
            // (Tính năng Multicasting của Delegate)
            this.openButton.OnButtonClick += this.OpenButtonClicked;

            // Thêm một phương thức vào sự kiện của button 'Save Button'.
            // (Tính năng Multicasting của Delegate)
            this.saveButton.OnButtonClick += this.SaveButtonClicked;
        }

        private void OpenButtonClicked(Button source, int x, int y)
        {
            // Mô phỏng mở ra một cửa sổ để chọn File để mở.
            Console.WriteLine("Open Dialog to Select a file");
            // 
            this.fileName = "File" + x + "_" + y + ".txt";
            Console.WriteLine("Openning file: " + this.fileName);
        }

        private void SaveButtonClicked(Button source, int x, int y)
        {
            if (this.fileName == null)
            {
                Console.WriteLine("No file to save!");
                return;
            }
            // Save File
            Console.WriteLine("Saved file: " + this.fileName);
        }


        public static void Main(string[] args)
        {

            // Mô phỏng mở ứng dụng
            MyApplication myApp = new MyApplication();

            Console.WriteLine("User Click on Open Button ....");

            // Mô phỏng openButton bị click
            myApp.openButton.Clicked();

            Console.WriteLine("\n\n");
            Console.WriteLine("User Click on Save Button ....");

            // Mô phỏng saveButton bị click
            myApp.saveButton.Clicked();


            Console.Read();

        }
    }
 
}