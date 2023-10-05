namespace Tutor_Net101_B5
{
    public class QuanLiXeCo
    {
        // Tao mot class QuanLiXeCo.cs gom List<XeCo>:
        // Them moi XC
        // Chinh sua thong tin XC
        // Xoa XC
        // Xuat danh sach

        // Khai bao -> khoi tao (WARNING !!!!!!!!!!!!!!!!!!!)
        List<XeCo> listXC = new()
        {
            //new XeCo() {MaXe="X1", NamSanXuat=2001, NhaSanXuat="NSX1", LaXeMoi=true},
            //new XeCo() {MaXe="X2", NamSanXuat=2002, NhaSanXuat="NSX2", LaXeMoi=false},
            //new XeCo() {MaXe="X3", NamSanXuat=2003, NhaSanXuat="NSX3", LaXeMoi=true},
        };

        public void Them()
        {
            // B1: Khoi tao doi tuong XeCo
            XeCo xeCo = new();

            // B2: Cho nguoi dung nhap thong tin cua doi tuong XeCo
            Console.Write("Nhap maXe: ");
            xeCo.MaXe = Console.ReadLine();
            Console.Write("Nhap namSanXuat: ");
            xeCo.NamSanXuat = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap nhaSanXuat: ");
            xeCo.NhaSanXuat = Console.ReadLine();
            Console.Write("Nhap laXeMoi: ");
            xeCo.LaXeMoi = Convert.ToBoolean(Console.ReadLine());

            // B3: Them doi tuong XeCo vao listXC
            listXC.Add(xeCo);
        }

        public void Sua()
        {
            if (listXC.Count == 0)
            {
                Console.WriteLine("Danh sach khong co phan tu nao");
                return;
            }

            // B1: Khoi tao doi tuong XeCo
            XeCo xeCoSua = new();

            // B2: Cho nguoi dung nhap vi tri muon sua
            Console.Write("Nhap vi tri muon sua: ");
            int viTri = Convert.ToInt32(Console.ReadLine());

            // listXC.Count = 0; viTri = -1 -> NO
            // listXC.Count = 0; viTri = 1 -> NO
            // listXC.Count = 1; viTri = 1 -> NO
            // listXC.Count = 2; viTri = 1 -> YES
            // => viTri >=0 && viTri < listXC.Count => YES
            if (viTri >= 0 && viTri < listXC.Count)
            {
                // B3: Cho nguoi dung nhap thong tin cua doi tuong XeCo
                Console.Write("Nhap maXe: ");
                xeCoSua.MaXe = Console.ReadLine();
                Console.Write("Nhap namSanXuat: ");
                xeCoSua.NamSanXuat = Int32.Parse(Console.ReadLine());
                Console.Write("Nhap nhaSanXuat: ");
                xeCoSua.NhaSanXuat = Console.ReadLine();
                Console.Write("Nhap laXeMoi: ");
                xeCoSua.LaXeMoi = Convert.ToBoolean(Console.ReadLine());

                // B4: Sua (gan lai ca doi tuong || gan lai thuoc tinh)
                // C1: gan lai ca doi tuong (recommend)
                listXC[viTri] = xeCoSua;

                //C2: gan lai thuoc tinh
                //listXC[viTri].MaXe = xeCoSua.MaXe;
                //listXC[viTri].NamSanXuat = xeCoSua.NamSanXuat;
                //listXC[viTri].NhaSanXuat = xeCoSua.NhaSanXuat;
                //listXC[viTri].LaXeMoi = xeCoSua.LaXeMoi;
            }
            else
            {
                Console.WriteLine("So luong phan tu: " + listXC.Count);
                Console.WriteLine("Nhap vi tri 0 - " + (listXC.Count - 1));
            }
        }

        public void Xoa()
        {
            if (listXC.Count == 0)
            {
                Console.WriteLine("Danh sach khong co phan tu nao");
                return;
            }

            // B1: Cho nguoi dung nhap vi tri muon sua
            Console.Write("Nhap vi tri muon sua: ");
            int viTri = Convert.ToInt32(Console.ReadLine());

            // listXC.Count = 0; viTri = 1 -> NO
            // listXC.Count = 1; viTri = 1 -> NO
            // listXC.Count = 2; viTri = 1 -> YES
            // => viTri >=0 && viTri < listXC.Count => YES
            if (viTri >= 0 && viTri < listXC.Count)
            {
                // B2: Xoa
                listXC.RemoveAt(viTri);
            }
            else
            {
                Console.WriteLine("So luong phan tu: " + listXC.Count);
                Console.WriteLine("Nhap vi tri 0 - " + (listXC.Count - 1));
            }
        }

        public void Xuat()
        {
            if (listXC.Count == 0)
            {
                Console.WriteLine("Danh sach khong co phan tu nao");
                return;
            }

            for (int i = 0; i < listXC.Count; i++)
            {
                listXC[i].InThongTin();
            }
        }
    }
}
