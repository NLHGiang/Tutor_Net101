// Tao mot class XeCo.cs gom:
// Thuoc tinh, constructor, property,InThongTin()

// Tao mot class QuanLiXeCo.cs gom List<XeCo>:
// Them moi XC
// Chinh sua thong tin XC
// Xoa XC
// Xuat danh sach

// Trong Program.cs co menu gom:
// Cac chuc nang co trong class QuanLiXeCo.cs
// 0. Thoat

#region List<DoiTuong>
//// Khai bao va khoi tao List<XeCo>
//List<XeCo> listXC = new List<XeCo>(); // Vi tri cua cac phan tu bat dau tu 0

//// Them vao List
//XeCo xeCo1 = new("X00", 2000);
//listXC.Add(xeCo1);

//for (int i = 1; i <= 5; i++)
//{
//    XeCo xeCo = new("X0" + $"{i}", 2000);
//    listXC.Add(xeCo);
//}

//// listXC.Count = so luong phan tu co trong List
//Console.WriteLine("So luong phan tu: " + listXC.Count); // = 6
//for (int i = 0; i < listXC.Count; i++)
//{
//    listXC[i].InThongTin();
//}

//Console.WriteLine("SUA===================================================");

//// Sua doi tuong trong List
//XeCo xeCoSua = new();
//listXC[2] = xeCoSua;
////listXC[7] = xeCoSua; // index = 7 -> vi tri = 8 -> ERROR vi vuot qua gioi han

//for (int i = 0; i < listXC.Count; i++)
//{
//    listXC[i].InThongTin();
//}

//Console.WriteLine("XOA===================================================");
//// Xoa doi tuong trong List
////listXC.RemoveRange(3, 2); // 3: vi tri bat dau Xoa, 2: so luong phan tu bi xoa
////listXC.RemoveAll(c=>c.Equals(xeCoSua)); // dieu kien Xoa (= lambda)
////listXC.Remove(xeCoSua);
//listXC.RemoveAt(2);

//// Hien thi cac doi tuong trong List
//for (int i = 0; i < listXC.Count; i++)
//{
//    listXC[i].InThongTin();
//}
#endregion

using Tutor_Net101_B5;

// Khai bao -> khoi tao NGOAI VONG LAP (WARNING !!!!!!!!!!!!!!!!!!!)
QuanLiXeCo quanLiXeCo = new QuanLiXeCo();

while (true)
{
    Console.WriteLine("============MENU============");
    Console.WriteLine("1. Them moi");
    Console.WriteLine("2. Chinh sua");
    Console.WriteLine("3. Xoa");
    Console.WriteLine("4. Hien thi danh sach");
    Console.WriteLine("0. Thoat");
    Console.Write("Lua chon cua ban: ");

    string luaChon = Console.ReadLine();

    switch (luaChon)
    {
        case "1":
            Console.WriteLine("1. Them moi");
            quanLiXeCo.Them();
            break;
        case "2":
            Console.WriteLine("2. Chinh sua");
            quanLiXeCo.Sua();
            break;
        case "3":
            Console.WriteLine("3. Xoa");
            quanLiXeCo.Xoa();
            break;
        case "4":
            Console.WriteLine("4. Hien thi danh sach");
            quanLiXeCo.Xuat();
            break;
        case "0":
            Console.WriteLine("<!> BAN DA THOAT !");
            return; // WARNING !!!!!!!!!!!!!!!!!!!
        default:
            Console.WriteLine("Nhap tu 0-4 thoi");
            break;
    }
}
