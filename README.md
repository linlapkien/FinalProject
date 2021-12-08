# FinalProject
Lin Lập Kiến - 2059019
 
Mail: 2059019@itec.hcmus.edu.vn

Project: https://github.com/linlapkien/FinalProject

---
# Module Soạn Đề

## Form1
### Soạn câu hỏi
- Soạn câu hỏi trắc nghiệm cho ngân hàng đề (phân loại: Câu hỏi, câu trả lời đúng, chủ đề)
- Nút Open Question Bank: Mở ngân hàng đề
- Nút Add, Delete, Modify cho phép thêm, xóa, chỉnh sửa câu hỏi trắc nghiệm trong ngân hàng đề
- Nút Save: Lưu lại thay đổi trên ngân hàng đề
- Sự kiện SelectedIndexChanged cho phép thay đổi các mục đã chọn để xem lại hoặc chỉnh sửa câu hỏi.
- Sự kiện doubleClick vào lbxQuestionBank cho phép thêm câu hỏi vào bộ đề thi nhanh hơn.

### Tạo ra đề thi
- Nút Create Quiz cho phép người dùng nhập số lượng câu hỏi, và bộ đề thi sẽ được tạo ra ngẫu nhiên từ ngân hàng đề.
- Bên cạnh đề được tạo ngẫu nhiên, người dùng có thể xóa hoặc thêm câu hỏi nhất định thông qua nút Add, Delete.
- sự kiện Keydown Delete cho phéo người dùng xóa câu hỏi trong bộ đề thi (tương tự nút Delete)
- Nút Save Quiz: Lưu đề thi đã tạo thành file XML
- Nút Score the quiz: nhảy qua frmScore để qua chức năng chấm bài.

## FrmScore
- Nút Question Bank cho phép người dùng chọn ngân hàng đề để chấm bài (câu hỏi bao gồm tất cả trong đề thi).
- Ngoài ra nếu Form1 đang có sẵn ngân hàng đề thi Nút Question Bank sẽ bị ẩn đi (mặc định ngân hàng đề bên Form1).
- Nút Import Answer Quiz: chọn folder chứa tất cả file (*.XML) bài làm của nhân viên.
- Nút Result: chấm điểm từng file *.XML bài làm của nhân viên và tổng hợp xuất ra file thông tin nhân viên và kết quả (*.txt).
- Nút Back: quay về giao diện Form1 (Vẫn còn lưu ngân hàng đề trước đó).
- Nút Exit: thoát chương trình.

---
# Module Thi Trắc Nghiệm
## frmLogin
- Giao diện đăng nhập trước khi vào thi (yêu cầu nhập tên + mã số nhân viên).

## frmThiTracNghiem
- Nút Open the exam: chọn đề thi trước khi làm bài.
- Nút Start: Bắt đầu làm bài và đồng hồ đếm ngược (tổng thời gian cho phép: số câu hỏi * 15s)
- userControl QuestionTable cho phép xáo câu trả lời ngẫu nhiên.
- Và nút Previous và nút Next cho phép chuyển câu hỏi và khi chuyển lại sẽ giữ vị trí câu trả lời và đáp án đã chọn.
- Nút Submit sẽ xuất ra file bài làm (*.XML) để nộp lại để chấm điểm.
- Sự kiện uscEClock_Exit của uscClock sẽ kiểm tra nếu hết giờ thì tự động nộp bài và thoát chương trình.
- Xuất file: Lưu tên và mã số nhân viên, mã đề thi và thời điểm làm bài.
