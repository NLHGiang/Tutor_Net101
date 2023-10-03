namespace Tutor_Net101_B4
{
    public class XeOTo : XeCo
    {
        public XeOTo()
        {
        }

        public XeOTo(string maXe, int namSanXuat) : base(maXe, namSanXuat)
        {
        }

        public XeOTo(string maXe, int namSanXuat, string nhaSanXuat, bool laXeMoi) : base(maXe, namSanXuat, nhaSanXuat, laXeMoi)
        {
        }

        public override void InThongTin()
        {
            Console.WriteLine("Day la o to");
            base.InThongTin();
        }
    }
}
