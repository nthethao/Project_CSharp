using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterface
{
    public class Mouse : Animal, CanEat, CanDrink
    {

        // Thực hiện phương thức trừu tượng của lớp Animal.
        // (Phải có từ khóa 'override').
        public override void Back()
        {
            Console.WriteLine("Mouse back ...");
        }

        // Thực hiện phương thức trừu tượng của lớp Animal. 
        public override int GetVelocity()
        {
            return 85;
        }

        // Thực hiện phương thức của interface CanDrink.
        public void Drink()
        {
            Console.WriteLine("Mouse drink ...");
        }

        // Thực hiện phương thức của interface CanEat.
        public void Eat()
        {
            Console.WriteLine("Mouse eat ...");
        }

    }

}