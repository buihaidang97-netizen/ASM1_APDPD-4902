# ASM1 APDP – Bộ code gốc và các đoạn bổ sung từ báo cáo

> Chỉ gồm code lớp học và **37 đoạn code có trong báo cáo ASM1 APDP SIMS 50 trang**. Đây KHÔNG PHẢI full SIMS. Không có phần nào của ASM2.

## Kết quả đối chiếu

- `code(1).zip` bạn gửi có **47 file C# nguồn `.cs`** thuộc các bài Lab; ngoài ra có dự án `.csproj`, `.slnx`.
- **12/37 đoạn code** có cơ sở từ `lab1`, `lab2`, `lab16.10`; trích đoạn rút gọn trong Word không nhất thiết trùng 100% với file Lab.
- **25/37 đoạn code** không có bản tương ứng trong ZIP Lab (các ví dụ về SIMS, dữ liệu, pattern, prototype và before/after) và được **bổ sung từ đúng báo cáo**.
- Toàn bộ **37 đoạn code từ Word** được lưu nguyên văn ở `02_Bo_Sung_Con_Thieu_Trong_Bai/` (25) và `03_Trich_Doan_Doi_Chieu_Lab/` (12).

## Thư mục

- `01_Code_Goc_Ban_Gui/code/`: mã nguồn gốc nguyên xi, giữ toàn bộ tên folder, namespace, class, interface, method, spelling, file dự án. Loại bỏ phần tự sinh `.vs/`, `bin/`, `obj/`, các file cache để tải GitHub gọn.
- `02_Bo_Sung_Con_Thieu_Trong_Bai/`: **25 đoạn code thiếu**, đã lấy từ bản báo cáo 50 trang, chia theo Task 1–5. Không chép đè vào code cũ.
- `03_Trich_Doan_Doi_Chieu_Lab/`: **12 đoạn code** trong báo cáo được rút gọn/chọn từ Lab, để bạn so khớp số Code với bài.
- `DOI_CHIEU_37_CODE.md` và `.csv`: bảng so từng Code 01–37 với file Lab liên quan. `MA_KIEM_TRA_FILE_GOC.csv` có SHA-256 chứng minh nội dung code Lab đã giữ nguyên.

## Cực kỳ quan trọng: tên gốc không được sửa

Giữ đúng `Caculator`, `TestCalcultor`, `FIleExporterOCP`, `IUseRepository`, `PayMnent`, `UserControllerDIP`, `Student`, `ITStudent`, `ClassWaitingList`, `EnrollmentService`, `EnrollmentServiceTests` và các tên khác trong nguồn ban đầu/bài báo cáo. Một số tên trông như lỗi chính tả vẫn được giữ để không lệch code Lab, project và tài liệu.

**Không biên dịch chung** `01_Code_Goc_Ban_Gui` và `02_Bo_Sung...` / `03_Trich_Doan...` thành một project: các snippet có thể trùng tên `Student`, `UserController` hoặc thiếu class/DTO bên ngoài. Đây là code minh họa được phân tách theo bài, không phải một ứng dụng SIMS hoàn chỉnh.

## Chạy riêng bài kiểm thử xUnit của prototype trong báo cáo

Thư mục:
`02_Bo_Sung_Con_Thieu_Trong_Bai/Task_3_Architecture_and_Testing/EnrollmentService_Prototype/`

Các file `EnrollmentService.cs`, `EnrollmentServiceTests.cs` được giữ theo báo cáo. File `.csproj` **chỉ là cấu hình hỗ trợ mới**.

Khi đã cài .NET 8 SDK và tải được NuGet, chạy:

```bash
dotnet test "02_Bo_Sung_Con_Thieu_Trong_Bai/Task_3_Architecture_and_Testing/EnrollmentService_Prototype/EnrollmentService_Prototype.Tests.csproj"
```

Báo cáo ghi nhận **7 Passed / 0 Failed**, nhưng lần đóng gói này **chưa chạy lại** vì môi trường hiện tại không có `dotnet` SDK. Không nên coi các đoạn code Adapter, Strategy, Observer hoặc các ví dụ Before/After là code hoàn thiện có thể chạy độc lập.

## Cảnh báo trước khi đăng GitHub công khai

File gốc `01_Code_Goc_Ban_Gui/code/lab2/lab2/Student.cs` có **họ tên và số điện thoại mẫu** được gán trực tiếp. Tôi đã giữ nguyên vì bạn yêu cầu không thay đổi code/tên; nếu những giá trị đó là thông tin thật, hãy thay **giá trị literal** trước khi công khai (không cần đổi tên class, field, method).

Chỉ upload code nguồn và các file README/CSV đi kèm. ZIP này đã loại bỏ cache IDE và output build.

## Nguồn và giới hạn

- `01_Code_Goc_Ban_Gui`: trích nguyên file từ `code(1).zip` do bạn gửi.
- `02_Bo_Sung_Con_Thieu_Trong_Bai` và `03_Trich_Doan_Doi_Chieu_Lab`: chép nguyên code từ phiên bản `ASM1_APDP_SIMS_Concise_50_Pages.docx` (các ví dụ Code 1–37).
- Không tự tạo SIMS web app, controllers CRUD thực tế, database, kết quả test mới hoặc dữ liệu trường học ngoài những gì có trong bài.
