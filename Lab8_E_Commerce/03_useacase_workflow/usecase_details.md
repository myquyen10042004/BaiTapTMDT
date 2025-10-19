# 🧩 Mô tả Use Case chi tiết – Hệ thống E-Kids Fashion (B2C)

---

## **UC01 – Duyệt danh mục / Tìm kiếm sản phẩm**
**Actor chính:** Khách hàng (Guest)  
**Mục tiêu:** Cho phép khách hàng xem danh mục và tìm kiếm sản phẩm theo nhu cầu.  
**Tiền điều kiện:** Hệ thống có dữ liệu sản phẩm.  

**Kịch bản chính:**
1. Khách hàng truy cập vào trang chủ.  
2. Chọn danh mục (bé trai, bé gái, sơ sinh…).  
3. Sử dụng thanh tìm kiếm hoặc bộ lọc theo giá, độ tuổi, thương hiệu.  
4. Hệ thống hiển thị danh sách sản phẩm phù hợp với tiêu chí.  

**Ngoại lệ:**  
3a. Không có sản phẩm phù hợp → hiển thị thông báo “Không tìm thấy sản phẩm”.  

**Hậu điều kiện:** Danh sách sản phẩm được hiển thị theo đúng tiêu chí lọc.

---

## **UC02 – Xem chi tiết sản phẩm**
**Actor chính:** Khách hàng (Guest)  
**Mục tiêu:** Hiển thị thông tin chi tiết sản phẩm cho khách xem trước khi đặt hàng.  
**Tiền điều kiện:** Sản phẩm tồn tại trong hệ thống.  

**Kịch bản chính:**
1. Khách hàng chọn một sản phẩm từ danh sách hiển thị.  
2. Hệ thống hiển thị thông tin chi tiết: tên, giá, hình ảnh, mô tả, tình trạng tồn kho.  
3. Khách hàng xem thông tin, chọn size, màu hoặc số lượng.  
4. Hiển thị nút “Thêm vào giỏ hàng”.  

**Ngoại lệ:**  
2a. Sản phẩm tạm hết hàng → hiển thị thông báo “Sản phẩm tạm hết”.  

**Hậu điều kiện:** Người dùng có thể chuyển sang bước thêm sản phẩm vào giỏ (UC03).

---

## **UC03 – Thêm vào giỏ / Cập nhật giỏ hàng**
**Actor chính:** Khách hàng (Guest)  
**Mục tiêu:** Thêm sản phẩm vào giỏ hàng hoặc chỉnh sửa giỏ hiện tại.  
**Tiền điều kiện:** Khách đã chọn sản phẩm hợp lệ.  

**Kịch bản chính:**
1. Khách hàng nhấn “Thêm vào giỏ”.  
2. Hệ thống kiểm tra tồn kho → thêm sản phẩm vào giỏ.  
3. Khách hàng có thể thay đổi số lượng hoặc xóa sản phẩm.  
4. Hệ thống cập nhật tổng tiền tự động.  

**Ngoại lệ:**  
2a. Sản phẩm hết hàng → báo lỗi không thể thêm.  
3a. Số lượng vượt tồn → hiển thị cảnh báo.  

**Hậu điều kiện:** Giỏ hàng được cập nhật chính xác với tổng tiền mới.

---

## **UC04 – Đặt hàng (COD)**
**Actor chính:** Khách hàng (Guest)  
**Mục tiêu:** Tạo đơn hàng COD thành công.  
**Tiền điều kiện:** Giỏ hàng không rỗng.  

**Kịch bản chính:**
1. Khách hàng mở giỏ hàng.  
2. Nhập họ tên, SĐT, địa chỉ.  
3. Chọn phương thức “COD”.  
4. Xác nhận đơn → hệ thống tạo mã đơn.  
5. Hệ thống hiển thị trạng thái “Đã tiếp nhận”.  

**Ngoại lệ:**  
3a. SĐT không hợp lệ → báo lỗi, yêu cầu nhập lại.  
4a. Hết hàng → đề xuất giảm số lượng / gợi ý sản phẩm khác.  

**Hậu điều kiện:** Đơn ở trạng thái “Đã tiếp nhận”.

---

## **UC05 – Theo dõi trạng thái đơn hàng**
**Actor chính:** Khách hàng (Guest)  
**Mục tiêu:** Giúp khách hàng theo dõi tiến trình đơn hàng.  
**Tiền điều kiện:** Đơn hàng đã được tạo thành công.  

**Kịch bản chính:**
1. Khách hàng chọn mục “Theo dõi đơn hàng”.  
2. Nhập mã đơn hoặc số điện thoại.  
3. Hệ thống hiển thị trạng thái đơn (đã tiếp nhận / đang giao / hoàn tất).  
4. Cung cấp chi tiết đơn vị vận chuyển.  

**Ngoại lệ:**  
2a. Mã đơn không tồn tại → hiển thị thông báo lỗi.  

**Hậu điều kiện:** Khách hàng nắm được tình trạng đơn hàng hiện tại.

---

## **UC06 – Quản lý sản phẩm**
**Actor chính:** Quản trị viên (Admin)  
**Mục tiêu:** Thêm, sửa, xóa hoặc cập nhật thông tin sản phẩm.  
**Tiền điều kiện:** Admin đã đăng nhập vào hệ thống.  

**Kịch bản chính:**
1. Admin chọn mục “Quản lý sản phẩm”.  
2. Thêm mới sản phẩm hoặc chỉnh sửa thông tin cũ.  
3. Lưu thay đổi → hệ thống cập nhật cơ sở dữ liệu.  
4. Có thể xóa sản phẩm không còn kinh doanh.  

**Ngoại lệ:**  
2a. Thiếu thông tin bắt buộc → hiển thị cảnh báo.  
3a. ID sản phẩm trùng → báo lỗi.  

**Hậu điều kiện:** Danh sách sản phẩm được cập nhật hợp lệ.

---

## **UC07 – Xem và quản lý đơn hàng**
**Actor chính:** Quản trị viên (Admin)  
**Mục tiêu:** Theo dõi và cập nhật trạng thái đơn hàng.  
**Tiền điều kiện:** Đơn hàng đã được tạo thành công.  

**Kịch bản chính:**
1. Admin chọn “Quản lý đơn hàng”.  
2. Hệ thống hiển thị danh sách đơn.  
3. Admin chọn một đơn cụ thể → xem chi tiết.  
4. Cập nhật trạng thái (đang giao / hoàn tất).  
5. Hệ thống gửi thông báo cho khách hàng.  

**Ngoại lệ:**  
2a. Không tải được danh sách → hiển thị lỗi truy vấn.  

**Hậu điều kiện:** Đơn hàng được cập nhật trạng thái chính xác.  
**Quan hệ:** `<<extend>>` UC09 – Xác nhận giao hàng.

---

## **UC08 – Gửi thông báo đơn hàng**
**Actor chính:** Hệ thống thông báo (Notification System)  
**Mục tiêu:** Gửi thông báo tự động đến khách hàng về trạng thái đơn hàng.  
**Tiền điều kiện:** Có sự kiện tạo hoặc cập nhật đơn hàng.  

**Kịch bản chính:**
1. Hệ thống nhận tín hiệu đơn hàng mới hoặc cập nhật.  
2. Tạo nội dung thông báo (mã đơn, thời gian, trạng thái).  
3. Gửi thông báo qua email / Zalo.  
4. Lưu lịch sử gửi thông báo.  

**Ngoại lệ:**  
3a. Kênh gửi thất bại → thử lại hoặc ghi log lỗi.  

**Hậu điều kiện:** Thông báo được gửi đến khách hàng thành công.

---

## **UC09 – Xác nhận giao hàng**
**Actor chính:** Đơn vị giao hàng (Delivery Unit)  
**Mục tiêu:** Cập nhật trạng thái đơn hàng sau khi giao.  
**Tiền điều kiện:** Đơn hàng đã được tạo và đang giao.  

**Kịch bản chính:**
1. Đơn vị giao hàng đăng nhập vào hệ thống phụ trợ.  
2. Chọn mã đơn cần cập nhật.  
3. Cập nhật trạng thái “Đã giao thành công” hoặc “Không giao được”.  
4. Hệ thống ghi nhận thay đổi và gửi thông báo đến khách hàng.  

**Ngoại lệ:**  
3a. Mã đơn không hợp lệ → báo lỗi.  

**Hậu điều kiện:** Đơn hàng được cập nhật trạng thái cuối cùng và lưu lịch sử.

---

✍️ **Thành viên thực hiện:**  
Trần Mỹ Quyên – 1150070037
