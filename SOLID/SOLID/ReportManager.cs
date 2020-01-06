using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // Nguyên lý số 1: Single responsibility principle
    public class ReportManager
    {
        public void ReadDataFromDB() { }
        public void ProcessData() { }
        public void PrintReport() { }

        // Class trên này vi phạm nguyên lý Single responsibility principle:
        // "Một class chỉ nên giữ 1 trách nhiệm duy nhất" (Chỉ có thể sửa đổi class với 1 lý do duy nhất)
        // Class này giữ tới 3 trách nhiệm: Đọc dữ liệu từ DB, xử lý dữ liệu, in kết quả
        // Do đó, chỉ cần ta thay đổi DB, thay đổi cách xuất kết quả, ... ta sẽ phải sửa đổi class này
        // Càng về sau class sẽ càng phình to ra.
        // Theo đúng nguyên lý, ta phải tách class này ra làm 3 class riêng
        // Tuy số lượng class nhiều hơn nhưng việc sửa chữa sẽ đơn giản hơn, class ngắn hơn nên cũng ít bug hơn.

    }

    // Nguyên lý 2: Open/Closed principle
    // Có thể thoải mái mở rộng 1 class, nhưng không được sửa đổi bên trong class đó (open for extension but closed for modification)
    // Theo nguyên lý này, mỗi khi ta muốn thêm chức năng, ... cho chương trình, chúng ta nên viết class mới mở rộng class cũ (kế thừa)
    // Không nên sửa đổi class cũ


    // Nguyên lý 3: Liskov Substitution Principle
    // Trong một chương trình, các object của class con có thể thay thế class cha mà không làm thay đổi tính đúng đắn của chương trình
    // Ví dụ: Tưởng tượng bạn có 1 class cha tên Vịt.
    // Các class Vịt Bầu, Vịt Xiêm có thể kế thừa class này, chương trình chạy bình thường.
    // Tuy nhiên, nếu ta viết class Vịt Chạy Pin, cần pin mới chạy được. Khi class này kế thừa class Vịt, vì không có pin không chạy được, sẽ gây lỗi
    // Đó là một trường hợp vi phạm nguyên lý này


    // Nguyên lý 4: Interface Segregation Principle
    // Thay vì dùng 1 interface lớn, ta nên tách thành nhiều interface nhỏ, với nhiều mục đích cụ thể
    // Ví dụ: Nếu có 1 interface lớn, khoảng 100 methods. Việc implements sẽ cực khổ, ngoài ra còn có thể dư thừa vì 1 class không cần dùng hết 100 methods.
    // Khi tách interface ra thành nhiều interface nhỏ, gồm các method liên quan tới nhau, việc implement và quản lý sẽ dễ hơn


    // Nguyên lý 5: Dependency inversion principle
    // 1. Các module cấp cao không nên phụ thuộc vào các modules cấp thấp. Cả 2 nên phụ thuộc vào abstraction
    // 2. Interface (abstraction) không nên phụ thuộc vào chi tiết, mà ngược lại (Các class giao tiếp với nhau thông qua interface, không phải thông qua implementation)
    // Ví dụ: Có 2 loại bóng đèn: Đèn tròn và đèn huỳnh quang.
    // Chúng cùng có "đuôi tròn", do đó ta có thể thay thế đèn tròn bằng đèn huỳnh quang cho nhau một cách dễ dàng
    // Ở đây, interface là "đuôi tròn", implementation là "bóng đèn tròn" và "bóng đèn huỳnh quang"
    // Ta có thể swap dễ dàng giữa 2 loại bóng vì ổ điện chỉ quan tâm tới interface (đuôi tròn), không quan tâm tới impletation.
    // Trong code cũng vậy, khi áp dụng Dependency inversion, ta chỉ quan tâm tới interface.
    // Để kết nối tới database, ta chỉ cần gọi hàm Get, Save, ... của Interface IDataAccess. 
    // Khi thay database, ta chỉ cần thay implementation của interface này.

}
