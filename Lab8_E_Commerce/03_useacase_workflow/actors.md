# 🎭 Giờ 3.1 – Liệt kê Actor trong hệ thống E-Kids Fashion

**Mục tiêu:**  
Xác định các tác nhân (actors) tương tác với hệ thống E-Kids Fashion – website bán quần áo trẻ em theo mô hình B2C.

---

## 👥 Danh sách Actor chính

| Actor | Loại Actor | Mô tả vai trò | Ghi chú |
|--------|-------------|---------------|----------|
| **Khách vãng lai (Guest)** | Primary | Người dùng chưa đăng ký tài khoản. Có thể xem danh mục, chi tiết sản phẩm, thêm vào giỏ, và đặt hàng COD. | Không cần đăng nhập. |
| **Khách đã đăng ký (Customer)** | Primary | Người dùng đã có tài khoản. Có thể lưu thông tin giao hàng, theo dõi lịch sử đơn hàng và nhận thông báo qua Zalo/email. | Tuỳ chọn kích hoạt ở Lab 3. |
| **Quản trị viên (Admin)** | Secondary | Người chịu trách nhiệm quản lý sản phẩm, tồn kho và xử lý đơn hàng (thêm/sửa/xoá sản phẩm, cập nhật trạng thái giao hàng). | Truy cập trang quản trị. |
| **Đơn vị vận chuyển (Shipper/Logistics)** | External | Nhận đơn từ hệ thống, thực hiện giao hàng và cập nhật trạng thái giao/hoàn tất. | Tạm mô phỏng nội bộ |
| **Hệ thống thông báo (Notification System)** | Supporting | Gửi thông báo trạng thái đơn hàng qua **Zalo hoặc email** cho khách hàng. | Ghi chú: triển khai ở phase sau. |

---
## Thành viên thực hiện:
Trần Mỹ Quyên 1150070037