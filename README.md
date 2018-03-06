# csharp_tree_project
Bài 1: Liệt kê thư mục và file
Trong Linux có một ứng dụng nổi tiếng có tên là tree để liệt kê toàn bộ thư mục và thư mục con + file

$ tree .
.
├── ReadMe.md
└── folderA
    ├── demo.cs
    ├── folderAA
    │   └── file.cs
    └── util.cs
Hãy viết một ứng dụng bằng C# nhận vào tham số là đường dẫn thư mục sau đó liệt kê toàn bộ nội dung thư mục đó. Chú ý nếu tham số là

. liệt kê thư mục hiện thời
.. liệt kê thư mục cha
~ liệt kê thư mục người dùng
