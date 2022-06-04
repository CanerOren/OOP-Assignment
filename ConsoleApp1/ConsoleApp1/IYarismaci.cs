using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IYarismaci
    {
        public string Isim { get; set; }
        public int  Konum{ get; set; }
        public int YarismaciNo { get; set; }

        public  int HareketEt(); 
    }
}
