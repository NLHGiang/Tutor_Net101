namespace Tutor_Net101_B4
{
    public abstract class XeCo
    {
        // thuoc tinh (attribute)
        string maXe;
        int namSanXuat;
        string nhaSanXuat;
        bool laXeMoi; // true: "Xe moi"; false: "Xe cu"

        // ham tao (constructor)
        // Khong tham so ("ctor" + Tab)
        public XeCo()
        {
            maXe = "???";
            namSanXuat = -1;
            nhaSanXuat = "???";
            laXeMoi = false;
        }

        // Co tham so
        public XeCo(string maXe, int namSanXuat)
        {
            this.maXe = maXe;
            this.namSanXuat = namSanXuat;
        }

        public XeCo(string maXe, int namSanXuat, string nhaSanXuat, bool laXeMoi)
        {
            this.maXe = maXe;
            this.namSanXuat = namSanXuat;
            this.nhaSanXuat = nhaSanXuat;
            this.laXeMoi = laXeMoi;
        }

        // getter, getter (property)
        public string MaXe { get => maXe; set => maXe = value; }
        public int NamSanXuat { get => namSanXuat; set => namSanXuat = value; }
        public string NhaSanXuat { get => nhaSanXuat; set => nhaSanXuat = value; }
        public bool LaXeMoi { get => laXeMoi; set => laXeMoi = value; }

        // phuong thuc #
        public virtual void InThongTin()
        {
            Console.WriteLine($"{MaXe} - {NamSanXuat} - {NhaSanXuat} - {LaXeMoi}");
        }
    }
}
