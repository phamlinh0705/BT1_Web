# BT1_Web

BÀI TẬP VỀ NHÀ 01:
TẠO SOLUTION GỒM CÁC PROJECT SAU:

1. DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
 
2. Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE

3. Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
   
4. Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.
   
Bài làm

Tên đề tài: MÁY TÍNH ĐƠN GIẢN

Sử dụng Visual Studio 2022

1. CLASS LIBRARY
Creat a new project ---> Bấm chọn class library (.NET Framework 2.0) và đặt tên: FunnyLib

Sửa lại tên file class1.cs = PersonalFunny.cs và thay code trong đó bằng các input, output, hàm. Nhấn build solution để ra được file Classlibrary.dll

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/e9e73c7c-f98b-4126-aba2-9001633ca941" />

Kết quả:

<img width="1091" height="823" alt="image" src="https://github.com/user-attachments/assets/3e93b781-4da0-4115-9880-ecc25edf5369" />

2. CONSOLE APP
   
Tạo project console app ( .NET Framework 2.0) thêm Reference tới Classlibrary.dll và sửa lại code trong Program.cs 

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/37d02e7a-614b-4f16-8e39-d261fbdf95db" />

Chuột phải vào project console ---> Set as startup project ---> F5 để chạy console app

Kết quả:

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/063be10a-a1ed-44d6-8024-6ec895b2f1f2" />

3. WINDOWS FORM APP
   
Tạo project Windows form app ( .NET Framework 2.0) thêm Reference tới maytinhdongian.dll.

Có 2 cách để tạo giao diện Design cho windows formm app:

Dùng thao tác đồ họa kéo thả các thanh toolbox vào khung

Dùng code thay thế cho các file .cs để tự động tạo giao diện

Dùng code để xây dựng giao diện cho đề tài máy tính đơn giản:

Program.cs:

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/35040477-b79d-47e3-9796-64755cb1dff2" />

Form1.cs:

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/d49b6808-dd16-4d24-bc42-1330ab0474d9" />

Tiếp tục project window form app ---> Set as startup project ---> F5 để chạy window form app

Kết quả chạy:

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/b8ef0f7d-b52c-44ea-b60c-92175110aa29" />

4. WEB FORM
   
Tạo project ASP.NET Web Application ( .NET Framework 2.0) thêm Reference tới Classlibrary.dll.

Từ project này add thêm 1 HTML page đặt tên index.html và 1 item tên api.aspx

Viết code html, css, js cho file index.html và code-behind cho api.aspx.cs

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/c46b96c3-8c7d-49ee-9ca7-e3f98c4fab92" />

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/f5b959b5-dcc2-490b-b090-a9f5b71f25f0" />

Deploy IIS + Host:

Mở IIS --> Add Website ---> Trỏ đến folder vừa Publish vào

Hostname: tuvi.local, Port: 80

Mở nodepad chay quyền admin và mở tệp hosts trong địa chỉ: C:\Windows\System32\drivers\etc\hosts. Thêm dòng "127.0.0.1  tuvi.local " vào cuối tệp và lưu lại.

Kết quả chạy trên localhost với tên miền là tuvi.local:

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/e32ba907-4f8e-4621-ba1b-6c952dd18bc3" />


