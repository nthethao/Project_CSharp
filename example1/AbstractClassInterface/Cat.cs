using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterface
{

    // Lớp Cat mở rộng từ lớp Animal và thực hiện 2 interface CanEat, CanDrink. 
    public class Cat : Animal, CanEat, CanDrink
    {

        private String name;

        public Cat(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }

        // Thực hiện phương thức trừu tượng của Animal.
        // (Phải ghi rõ 'override' ).
        public override void Back()
        {
            Console.WriteLine(name + " cat back ...");
        }

        // Thực hiện phương thức trìu tượng của Animal.
        // (Phải ghi rõ 'override' )
        public override int GetVelocity()
        {
            return 110;
        }

        // Thực hiện phương thức của interface CanEat    
        public void Eat()
        {
            Console.WriteLine(name + " cat eat ...");
        }

        // Thực hiện phương thức của interface CanDrink 
        public void Drink()
        {
            Console.WriteLine(name + " cat drink ...");
        }

    }

}