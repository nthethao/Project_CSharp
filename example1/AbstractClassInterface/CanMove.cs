using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterface
{
    // Interface này định nghĩa những thứ có khả năng di chuyển.
    public interface CanMove
    {

        // Các phương thức trong Interface đều là công khai và trừu tượng (public abstract)
        // (Nhưng bạn không được phép viết public hoặc abstract ở đây).
        void Run();

        // Quay trở lại. 
        void Back();

        // Trả về vận tốc chạy.
        int GetVelocity();

    }
}
