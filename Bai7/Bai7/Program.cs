 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            var td = new CToaDo(5, 5, "O");
            var ht = new CHinhTron(td , 10.5);
            Console.WriteLine("Hinh tron co tam {0} voi ban kinh {1} co dien tich va chu vi lan luot la {2} va {3}", 
                ht.Tam.ToString(),ht.BanKinh,ht.tinhDienTich(),ht.tinhChuVi());
            Console.ReadKey();
        }
    }
}
