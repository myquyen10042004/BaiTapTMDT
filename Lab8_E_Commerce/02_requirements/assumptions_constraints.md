# ⚙️ Giờ 1.3 – Đặt ràng buộc & giả định cho hệ thống E-Kids Fashion (B2C)

## 1. Giả định (Assumptions)

| STT | Giả định | Giải thích |
|------|-----------|------------|
| 1 | Khách hàng có kết nối Internet ổn định. | Để truy cập website và thực hiện đặt hàng. |
| 2 | Khách hàng chấp nhận hình thức thanh toán COD (Cash on Delivery). | Hệ thống ở Lab 1 chưa tích hợp cổng thanh toán online. |
| 3 | Quản trị viên đã nhập sẵn danh mục sản phẩm và thông tin cơ bản. | Giúp khách hàng có thể duyệt sản phẩm ngay khi chạy thử. |
| 4 | Dữ liệu thử nghiệm (hình ảnh, giá, mô tả) được cung cấp trước. | Đảm bảo hệ thống mô phỏng có dữ liệu sẵn để test. |
| 5 | Bên giao hàng giả định hoạt động đúng lịch trình, không tính trễ giao. | Vì Lab chỉ mô phỏng chức năng quản lý đơn hàng. |

---

## 2. Ràng buộc (Constraints)

| STT | Ràng buộc | Giải thích |
|------|------------|------------|
| 1 | Không tích hợp cổng thanh toán online (VNPay, Momo) trong Lab 1. | Giới hạn phạm vi chức năng. |
| 2 | Hệ thống thiết kế **mobile-first**, ưu tiên hiển thị tốt trên điện thoại. | Do khách hàng mục tiêu chủ yếu mua bằng smartphone. |
| 3 | Cơ sở dữ liệu chỉ gồm tối đa 100 sản phẩm và 50 người dùng thử. | Giới hạn tài nguyên và quy mô thử nghiệm. |
| 4 | Hệ thống chạy cục bộ (localhost), không triển khai ra Internet. | Đảm bảo an toàn và thuận tiện trong quá trình học tập. |
---

## 3. Tiêu chí thành công (Success Criteria)

| STT | Tiêu chí | Mô tả cụ thể |
|------|-----------|--------------|
| 1 | Khách hàng tạo đơn hàng thành công trong ≤ 3 phút. | Từ lúc chọn sản phẩm đến khi xác nhận đơn hàng. |
| 2 | Quản trị viên có thể xem và xác nhận đơn hàng mới. | Đảm bảo quy trình xử lý đơn hoạt động trơn tru. |
| 3 | Hệ thống hiển thị đúng dữ liệu sản phẩm, giá và giỏ hàng. | Không xảy ra lỗi logic hoặc mất dữ liệu. |
| 4 | Giao diện hiển thị đúng trên thiết bị di động. | Đảm bảo UX thân thiện, dễ thao tác. |
| 5 | 100% dữ liệu đặt hàng được lưu thành công vào cơ sở dữ liệu. | Đảm bảo tính toàn vẹn dữ liệu. |

---

## Thành viên thực hiện:
Ma Thị Thu Ánh 1150070001