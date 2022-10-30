using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001202045_VuNgoDat_SM24_Buoi7.Models
{
    public class Student
    {
        private string ma, ten, maLop;
        private DateTime ngSinh;

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public DateTime NgSinh { get => ngSinh; set => ngSinh = value; }

        public Student(string ma, string ten, string maLop, DateTime ngSinh)
        {
            Ma = ma;
            Ten = ten;
            MaLop = maLop;
            NgSinh = ngSinh;
        }

        public Student()
        {
        }
    }
}
