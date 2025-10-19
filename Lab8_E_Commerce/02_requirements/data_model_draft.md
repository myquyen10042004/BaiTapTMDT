# 🧩 Xác định dữ liệu cốt lõi – Hệ thống E-Kids Fashion (B2C)

## 🎯 Mục tiêu
Xác định các **thực thể dữ liệu cốt lõi** trong hệ thống thương mại điện tử bán quần áo trẻ em **E-Kids Fashion (B2C)**.  
5 bảng này phối hợp để mô phỏng toàn bộ quy trình nghiệp vụ “Đặt hàng – Giao hàng – Thông báo”, từ lúc khách duyệt sản phẩm đến khi đơn hàng hoàn tất.

---

## 1. 🧱 Bảng Sản phẩm (Product)

| Thuộc tính | Kiểu dữ liệu | Mô tả |
|-------------|--------------|-------|
| `MaSanPham` | INT | Mã sản phẩm (Khóa chính) |
| `TenSanPham` | NVARCHAR(255) | Tên sản phẩm |
| `GiaBan` | DECIMAL(10,2) | Giá bán sản phẩm |
| `HinhAnh[]` | LIST\<STRING\> | Danh sách hình ảnh sản phẩm |
| `SoLuongTon` | INT | Số lượng tồn kho dự kiến |

**Giải thích:**  
Bảng **Sản phẩm** lưu thông tin các mặt hàng quần áo trẻ em được hiển thị trên website/app để người dùng tìm kiếm, xem chi tiết hoặc đặt mua.

---

## 2. 🛒 Bảng Giỏ hàng (Cart)

| Thuộc tính | Kiểu dữ liệu | Mô tả |
|-------------|--------------|-------|
| `MaGioHang` | STRING | Mã giỏ hàng (theo phiên đăng nhập hoặc khách vãng lai) |
| `DanhSachSP[{MaSanPham, SoLuong}]` | JSON | Danh sách sản phẩm và số lượng tương ứng |
| `TongTien` | DECIMAL(10,2) | Tổng giá trị đơn hàng tạm tính |

**Giải thích:**  
Bảng **Giỏ hàng** dùng để lưu tạm thời các sản phẩm mà khách hàng đã chọn mua.  
Khi người dùng xác nhận đặt hàng, dữ liệu trong giỏ sẽ được chuyển sang bảng **Đơn hàng**.

---

## 3. 📦 Bảng Đơn hàng (Order)

| Thuộc tính | Kiểu dữ liệu | Mô tả |
|-------------|--------------|-------|
| `MaDonHang` | INT | Mã đơn hàng (Khóa chính) |
| `HoTenKhachHang` | NVARCHAR(255) | Họ và tên người mua |
| `SoDienThoai` | VARCHAR(20) | Số điện thoại liên hệ |
| `DiaChi` | NVARCHAR(255) | Địa chỉ giao hàng |
| `DanhSachSP[]` | JSON | Danh sách sản phẩm + số lượng |
| `TongTien` | DECIMAL(10,2) | Tổng tiền đơn hàng |
| `PhuongThucThanhToan` | VARCHAR(10) | Hình thức thanh toán (COD / chuyển khoản) |
| `TrangThai` | VARCHAR(30) | Trạng thái đơn hàng (Đã tiếp nhận / Đang giao / Hoàn tất) |

**Giải thích:**  
Bảng **Đơn hàng** là bảng trung tâm trong hệ thống — ghi nhận toàn bộ quy trình đặt hàng, xử lý và giao hàng.  
Liên kết với **Khách hàng**, **Đơn vị giao hàng** và **Hệ thống thông báo**.

---

## 4. 👤 Bảng Người dùng (User)

| Thuộc tính | Kiểu dữ liệu | Mô tả |
|-------------|--------------|-------|
| `MaNguoiDung` | INT | Mã tài khoản |
| `TenDangNhap` | VARCHAR(50) | Tên đăng nhập |
| `MatKhau` | VARCHAR(255) | Mật khẩu (được mã hóa) |
| `VaiTro` | VARCHAR(20) | Vai trò (Admin hoặc Khách hàng) |

**Giải thích:**  
Bảng **Người dùng** giúp phân quyền truy cập hệ thống.  
Quản trị viên (Admin) có thể quản lý sản phẩm và đơn hàng, trong khi khách hàng chỉ được phép đặt và theo dõi đơn.

---

## 5. 🔔 Bảng Thông báo (Notification)

| Thuộc tính | Kiểu dữ liệu | Mô tả |
|-------------|--------------|-------|
| `MaThongBao` | INT | Mã thông báo |
| `MaDonHang` | INT | Liên kết tới đơn hàng cần gửi thông báo |
| `NoiDung` | NVARCHAR(255) | Nội dung thông báo |
| `TrangThai` | VARCHAR(20) | Trạng thái (Đã gửi / Chưa gửi) |
| `NgayTao` | DATETIME | Thời điểm tạo thông báo |

**Giải thích:**  
Bảng **Thông báo** dùng để lưu lịch sử gửi thông tin đơn hàng qua Email hoặc Zalo.  
Mỗi lần đơn hàng thay đổi trạng thái, hệ thống sẽ tự động sinh thông báo mới.

---

✍️ **Người thực hiện:**  
**Trần Mỹ Quyên – 1150070037**
