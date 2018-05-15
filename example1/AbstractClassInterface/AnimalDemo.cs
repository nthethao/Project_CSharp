using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterface
{

    public class AnimalDemo
    {

        public static void Main(string[] args)
        {

            // Tạo một đối tượng CanEat.
            // Một đối tượng khai báo là CanEat
            // Nhưng thực tế là Cat.
            CanEat canEat1 = new Cat("Tom");

            // Một đối tượng khai báo là CanEat
            // Nhưng thực tế là Mouse.
            CanEat canEat2 = new Mouse();

            // Tính đa hình (Polymorphism) thể hiện rõ tại đây.
            // CSharp luôn biết kiểu thực tế của một đối tượng.
            // ==> Tom cat eat ...
            canEat1.Eat();

            // ==> Mouse eat ...
            canEat2.Eat();

            bool isCat = canEat1 is Cat;// true

            Console.WriteLine("catEat1 is Cat? " + isCat);

            // Kiểm tra 'canEat2' có phải là chuột hay không?.
            if (canEat2 is Mouse)
            {
                // Ép kiểu
                Mouse mouse = (Mouse)canEat2;

                // Gọi phương thức Drink() (Thừa kế từ CanDrink).
                mouse.Drink();
            }

            Console.ReadLine();
        }
    }

}