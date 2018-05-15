using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterface
{

    // Animal (Một lớp mô phỏng lớp động vật)
    // Nó mở rộng từ lớp Object (Mặc dù không ghi rõ ràng).
    // Và khai báo thực hiện (implements) interface CanMove.
    // Interface CanMove có 3 phương thức trừu tượng.
    // Lớp này mới thực hiện 1 phương thức của CanMove.
    // Vì vậy nó bắt buộc phải khai báo là 'abstract'.
    // Các phương thức còn lại phải được khai báo lại với 'public abstract'.
    public abstract class Animal : CanMove
    {

        // Thực hiện phương thức Run() của interface CanMove. 
        // Bạn phải viết nội dung của phương thức.
        // Modifier phải là public.
        public void Run()
        {
            Console.WriteLine("Animal run...");
        }

        // Nếu lớp này không thực hiện một phương thức nào đó của Interface 
        // bạn phải viết lại nó như là một phương thức trừu tượng.
        // (Luôn luôn là 'public abstract')
        public abstract void Back();

        public abstract int GetVelocity();

    }


}