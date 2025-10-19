# 📘 Giờ 2.3 – Chuyển thành yêu cầu hệ thống (E-Kids Fashion)

**Mục tiêu:**  
Phân tích và tổng hợp yêu cầu chức năng (FR) và phi chức năng (NFR) cho hệ thống thương mại điện tử **E-Kids Fashion** – website bán quần áo trẻ em theo mô hình B2C.

---

## 🧩 Yêu cầu chức năng (Functional Requirements – FR)

| Mã | Mô tả yêu cầu | Ghi chú |
|----|----------------|---------|
| **FR1** | Hệ thống cho phép **tìm kiếm và lọc sản phẩm** theo danh mục, độ tuổi, giới tính, giá, màu sắc, hoặc chất liệu. | Người dùng nhập từ khóa hoặc chọn bộ lọc. |
| **FR2** | Người dùng có thể **xem chi tiết sản phẩm** gồm hình ảnh, mô tả, size, giá, số lượng tồn, đánh giá và gợi ý combo liên quan. | Màn hình chi tiết sản phẩm. |
| **FR3** | Người dùng có thể **thêm sản phẩm vào giỏ hàng**, cập nhật số lượng, xem tổng tiền, hoặc xóa sản phẩm khỏi giỏ. | Tự động tính lại tổng giá trị đơn. |
| **FR4** | Cho phép **đặt hàng COD**, thu thập thông tin khách hàng (họ tên, SĐT, địa chỉ giao hàng, ghi chú). | Chưa tích hợp thanh toán online ở Lab 1. |
| **FR5** | Người dùng có thể **theo dõi trạng thái đơn hàng** (đã tiếp nhận / đang giao / hoàn tất) qua Zalo hoặc website. | Dữ liệu cập nhật tự động từ hệ thống. |
| **FR6** | **Admin** được phép thêm, sửa, xóa sản phẩm và xem danh sách đơn hàng khách đã đặt. | Giao diện quản trị nội bộ. |

---

## ⚙️ Yêu cầu phi chức năng (Non-Functional Requirements – NFR)

| Mã | Mô tả yêu cầu | Ghi chú |
|----|----------------|---------|
| **NFR1** | Thời gian tải trang chủ **< 2 giây** khi sử dụng mạng 4G. | Đảm bảo hiệu năng người dùng di động. |
| **NFR2** | Giao diện **mobile-first**, tối ưu cho màn hình điện thoại. | Phù hợp với hành vi mua hàng qua điện thoại. |
| **NFR3** | Đảm bảo **bảo mật thông tin cá nhân**, che 3 số cuối của SĐT khi hiển thị. | Tuân thủ quy định bảo vệ dữ liệu. |
| **NFR4** | Hệ thống có khả năng mở rộng để **tích hợp thanh toán online** (Momo, ZaloPay) ở giai đoạn sau. | Chuẩn bị cho Lab sau – mở rộng tính năng. |

---

## Thành viên thực hiện:
Huỳnh Khánh Phong 1150070034