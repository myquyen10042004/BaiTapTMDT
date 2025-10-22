# 🧩 Báo cáo nhóm – Lab 1: Phân tích hệ thống E-Kids Fashion (B2C)

## **1️⃣ Giới thiệu & Mục tiêu Lab**

* Hiểu quy trình phân tích – thiết kế hệ thống thương mại điện tử (TMĐT).
* Xây dựng mô hình **B2C bán quần áo trẻ em** gồm: khách hàng, quản trị viên, đơn vị giao hàng.
* Thực hành các bước: phỏng vấn, thu thập yêu cầu, vẽ Use Case, Workflow, thiết kế Mockup UI.

---

## **2️⃣ Mô tả ý tưởng / sản phẩm**

* Hệ thống **E-Kids Fashion** hỗ trợ khách hàng mua sắm quần áo trẻ em trực tuyến.
* Quy trình chính: Xem sản phẩm → Thêm vào giỏ → Đặt hàng COD → Theo dõi đơn.
* Phạm vi Lab 1: tập trung **đặt hàng COD**, **quản lý sản phẩm**, **xem chi tiết đơn hàng**.

---

## **3️⃣ Phương pháp thu thập yêu cầu**

* **Phỏng vấn giả lập (10 câu hỏi)**: khai thác hành vi mua sắm, hình thức thanh toán, nhu cầu bảo hành.
* **Khảo sát nhanh (6 câu hỏi)**: dùng Google Form/giấy mô phỏng.
* File liên quan: `02_requirements/interview_questions.md`, `02_requirements/survey.md`.

---

## **4️⃣ Phân tích yêu cầu**

### ✅ **Yêu cầu chức năng (FR)**

* FR1: Tìm kiếm và lọc sản phẩm theo giá/nhóm.
* FR2: Xem chi tiết sản phẩm, ảnh, mô tả, tồn kho.
* FR3: Thêm vào giỏ hàng và cập nhật số lượng.
* FR4: Đặt hàng COD (tên, SĐT, địa chỉ, xác nhận đơn).
* FR5: Theo dõi đơn hàng (đang xử lý/đã giao).
* FR6: Admin quản lý sản phẩm và đơn hàng.

### ⚙️ **Phi chức năng (NFR)**

* NFR1: Tải trang < 2s với kết nối 4G.
* NFR2: Giao diện mobile-first.
* NFR3: Bảo mật SĐT (ẩn 3 số cuối).
* NFR4: Hỗ trợ mở rộng thanh toán online ở Phase 2.

File: `02_requirements/requirements.md`.

---

## **5️⃣ Actor & Use Case**

* **Actor chính:** Khách hàng, Quản trị viên, Hệ thống thông báo, Đơn vị giao hàng.
* **Tổng cộng 9 Use Case:** UC01–UC09.
* File sơ đồ: `03_usecase_workflow/usecase_diagram.puml`.
---

# 🧭 6️⃣ Workflow nghiệp vụ

## 🛍️ Quy trình “Đặt hàng COD”

### Mô tả tổng quan
Quy trình này mô phỏng luồng nghiệp vụ chính khi khách hàng thực hiện mua hàng bằng hình thức **thanh toán khi nhận hàng (COD)** trong hệ thống **E-Kids Fashion (B2C)**.  
Các tác nhân tham gia gồm: **Khách hàng**, **Hệ thống**, **Quản trị viên**, và **Đơn vị giao hàng**.

---

### 🔄 Các bước thực hiện

1. **Khách hàng** truy cập website, xem danh mục và chọn sản phẩm cần mua.  
2. Thêm sản phẩm vào **giỏ hàng**, chọn phương thức **thanh toán COD** và xác nhận đơn hàng.  
3. **Hệ thống** kiểm tra dữ liệu đơn hàng, khởi tạo **mã đơn hàng** và lưu vào **CSDL**.  
4. Hệ thống gửi thông báo **“Đã tiếp nhận đơn hàng”** đến khách hàng.  
5. **Quản trị viên** nhận thông tin đơn hàng mới, kiểm tra kho và xác nhận giao hàng.  
6. Quản trị viên cập nhật trạng thái đơn sang **“Đang giao hàng”** và chuyển thông tin cho **đơn vị giao hàng**.  
7. **Đơn vị giao hàng** nhận đơn cần giao và tiến hành giao hàng đến khách hàng.  
8. Nếu giao thành công → cập nhật trạng thái **“Đã giao”**; nếu không giao được → trạng thái **“Không giao được”**.  
9. **Hệ thống** nhận kết quả, cập nhật trạng thái cuối trong CSDL và gửi thông báo **“Hoàn tất đơn hàng”** cho khách hàng.  
10. **Khách hàng** nhận thông báo hoàn tất và có thể **đánh giá dịch vụ** sau khi nhận hàng.

---

### 🗂️ Tóm tắt vai trò và tương tác

| Tác nhân | Vai trò chính | Tương tác với hệ thống |
|-----------|----------------|------------------------|
| **Khách hàng** | Tạo và xác nhận đơn hàng COD | Gửi thông tin đơn, nhận thông báo trạng thái |
| **Hệ thống** | Xử lý và lưu trữ đơn hàng | Tạo mã đơn, cập nhật trạng thái, gửi thông báo |
| **Quản trị viên** | Kiểm tra kho, xác nhận giao hàng | Cập nhật “Đang giao hàng”, điều phối đơn |
| **Đơn vị giao hàng** | Giao hàng và phản hồi kết quả | Báo trạng thái “Đã giao / Không giao được” |

---

### 🖼️ Hình minh họa sơ đồ
📁 *File ảnh/sơ đồ:* `03_usecase_workflow/workflow_order.png`

---

### 💬 Ghi chú
- Quy trình có thể mở rộng cho hình thức **thanh toán Online** ở giai đoạn tiếp theo.  
- Nên tích hợp **API giao hàng tự động** (Giao Hàng Nhanh, GHN, Viettel Post...) để đồng bộ trạng thái.  
- Dữ liệu cập nhật theo **thời gian thực** giúp khách hàng theo dõi đơn hàng chính xác hơn.


## **7️⃣ Mockup UI (Giao diện)**

* **4 màn hình chính:**

  1. Trang chủ / Danh mục.
  2. Chi tiết sản phẩm.
  3. Giỏ hàng.
  4. Đặt hàng COD.
* Thiết kế theo **mobile-first**, nút lớn (44px), màu cam – xám – trắng.
* File mockup: `04_mockup/ekids_mockup.png`.

---

## **8️⃣ Khác biệt B2C vs B2B**

* Được trình bày chi tiết trong file: `05_report/check_questions.md`.
* Tóm tắt 4 nhóm so sánh:

  * B2C vs B2B.
  * Marketplace vs E-shop.
  * COD vs Online Payment.
  * Web App vs Mobile App.

---

## **9️⃣ Kết luận & Hướng phát triển Lab 2**

* Hoàn thành toàn bộ quy trình phân tích: từ yêu cầu đến giao diện.
* Củng cố kỹ năng teamwork, quản lý yêu cầu và biểu diễn Use Case.
* **Lab 2:** mở rộng chức năng Backend (quản lý tài khoản, sản phẩm, API Android, lưu đơn hàng).

---

## **🔟 Phân công công việc & nhật ký nhóm**

### 🧑‍🤝‍🧑 Thành viên nhóm

| **Tên**             | **MSSV**       | **Lớp**     | **Vai trò**                            | **Công việc thực hiện**                                                                              |
| ------------------- | -------------- | ----------- | -------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| Ma Thị Thu Ánh      | 1150070001     | 11–TMĐT     | **Thành viên (PM hỗ trợ)**             | Chốt ý tưởng, xác định phạm vi và mục tiêu hệ thống.                                                 |
| Lê Nguyễn Đăng Khoa | 1150070021     | 11–TMĐT     | **UI/UX Designer**                     | Thiết kế giao diện cơ bản, xây dựng mockup và quy ước UI.                                            |
| Huỳnh Khánh Phong   | 1150070034     | 11–TMĐT     | **Business Analyst (BA)**              | Thu thập và phân tích yêu cầu người dùng (FR/NFR).                                                   |
| Trần Mỹ Quyên   | 1150070037 | 11–TMĐT | **Nhóm trưởng / Project Manager (PM)** | Điều phối công việc nhóm, thiết kế Use Case, mô tả chi tiết quy trình nghiệp vụ và vẽ luồng dữ liệu. |

---


