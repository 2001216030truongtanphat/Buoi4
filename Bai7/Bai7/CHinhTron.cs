using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class CHinhTron
    {
        private CToaDo _tam;
        public CToaDo Tam
        {
            get { return _tam; }
            set { _tam = value; }
        }
        private double banKinh;
        public double BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }
        public CHinhTron()
        {
            this.Tam = new CToaDo();
            BanKinh = 0;
        }
        public CHinhTron(CToaDo t, double bk)
        {
            this.Tam = t;
            this.Tam.X = t.X;
            this.Tam.Y = t.Y;
            this.Tam.Ten = t.Ten;
            this.BanKinh = bk;
        }
        public double tinhChuVi()
        {
            return BanKinh * 2 * 3.14;
        }
        public double tinhDienTich()
        {
            return BanKinh * BanKinh * 3.14;
        }

    }
}
