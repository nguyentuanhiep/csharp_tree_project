# Bài 1: Liệt kê thư mục và file
## Yêu cầu bài toán:
Trong Linux có một ứng dụng nổi tiếng có tên là tree để liệt kê toàn bộ thư mục và thư mục con + file
```
$ tree .
.
├── ReadMe.md
└── folderA
    ├── demo.cs
    ├── folderAA
    │   └── file.cs
    └── util.cs
```
Hãy viết một ứng dụng bằng C# nhận vào tham số là đường dẫn thư mục sau đó liệt kê toàn bộ nội dung thư mục đó.
Chú ý nếu tham số là
- . liệt kê thư mục hiện thời
- .. liệt kê thư mục cha
- ~ liệt kê thư mục người dùng 

## Mô tả kiến trúc ứng dụng
Ứng dụng chạy theo phương pháp đệ quy ```Tree(string path, string padding)``` path là thư mục, padding là phần cách lề của thư mục.
- Đầu tiên, ứng dụng sẽ lấy tất cả thư mục và file cấp 1.
- Vẽ tất cả thư mục vừa lấy được.
- Với mỗi thư mục vừa lấy, ta gọi lại hàm **Tree** với thư mục đó.
- Vẽ file trong tất cả các thư mục.
