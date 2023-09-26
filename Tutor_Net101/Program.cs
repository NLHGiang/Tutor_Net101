#region Xuất
//Console.Write("Hello, world!"); // In ra
//Console.WriteLine("Hello, world!"); // In ra -> xuống dòng
#endregion

#region Nhập
//// int, float, decimal, double, string, bool (false/true)
//// Người dùng nhập số nguyên a
////int a = Console.ReadLine(); //int = string -> int = int

//// Ép kiểu = Parse
//int a1 = Int32.Parse(Console.ReadLine());

//// Ép kiểu = Convert
//int a2 = Convert.ToInt32(Console.ReadLine());
#endregion

#region Nhập, xuất với int
//// Nhập 2 số nguyên a và b
//// Xuất ra màn hình console kết quả a+b

//// Nhập a,b
//Console.Write("Nhap a = ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.Write("Nhap b = ");
//int b = Convert.ToInt32(Console.ReadLine());

//// Tính a+b
//int tong = a + b;

//// Hiển thị kết quả a+b ra màn hình
//Console.WriteLine("Tong a + b = ", tong);
//Console.WriteLine($"Tong a + b = {tong}");

//Console.WriteLine("Tong {0} + {1} = {2}", a, b, tong);
//Console.WriteLine($"Tong {a} + {b} = {tong}");
#endregion

#region Nhập, xuất với bool
//bool a; // default value: false
//a = Convert.ToBoolean(Console.ReadLine()); //"true"/"false"
#endregion

#region Nhập, xuất với string
//string a = Console.ReadLine();
#endregion

#region Bài tập 1
//// Người dùng nhập 2 số nguyên a,b
//// Hiển thị ra màn hình kết quả a+b,a-b,a*b,a/b,a%b

//// Nhập a, b
//Console.WriteLine("Bai tap 1");
//Console.Write("Nhap a = ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.Write("Nhap b = ");
//int b = Convert.ToInt32(Console.ReadLine());

//// Tính kết quả a+b,a-b,a*b,a/b,a%b
//int tong = a + b;
//int hieu = a - b;
//int tich = a * b;
////float thuong = float.Parse(Convert.ToString(a)) / b; // float/int=float -> 1.0/2 = 0.5
////float thuong = Convert.ToSingle(a) / b; // float/int=float -> 1.0/2 = 0.5
//float thuong = (float)a / b; // float/int=float -> 1.0/2 = 0.5
//int soDu = a % b;

//Console.WriteLine($"{a} + {b} = {tong}");
//Console.WriteLine($"{a} - {b} = {hieu}");
//Console.WriteLine($"{a} * {b} = {tich}");
//Console.WriteLine($"{a} / {b} = {thuong}");
//Console.WriteLine($"{a} % {b} = {soDu}");

#endregion

// ref, out
//string testString = "hahaha";
//float testFloat = 1.5f;
//bool testTryParse = float.TryParse(testString, out testFloat);
//if (testTryParse == true)// Có thể convert (int)a -> (float)testFloat
//{
//    Console.WriteLine($"TryParse: {testFloat}");
//}
//else // Không thể ép kiểu
//{
//    Console.WriteLine($"TryParse: {testFloat}");
//    Console.WriteLine("int a không -> float testFloat");
//}

//Console.WriteLine("Parse: " + float.Parse(testString));
//Console.WriteLine("Convert: " + Convert.ToSingle(testString));