using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SalyanBot:Robot
    {
        public override int HareketEt()
        {
            base.Konum += 1;
            return base.Konum ;
        }

        public SalyanBot(string isim, int yarismaciNo, int yarismaPisti) : base(isim, yarismaciNo,yarismaPisti)
        {
            base.Isim = isim;
            
            base.YarismaciNo = yarismaciNo;

            base.yarismaPisti = yarismaPisti;
        }
    }
}
