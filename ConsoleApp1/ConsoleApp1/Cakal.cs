using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cakal:Hayvan
    {
        public override int HareketEt()
        {
            base.rng = new Random().Next(1, 101);
            
            if (base.rng > 0 && base.rng <= 30)
            {
                if((base.Konum+3)>= base.yarismaPisti)
                {
                    base.Konum= base.yarismaPisti;
                }
                else
                {
                    base.Konum += 3;
                }
            }

            else if (base.rng > 30 && base.rng <= 80)
            {
                if((base.Konum+2)>=base.yarismaPisti)
                {
                    base.Konum = base.yarismaPisti;
                }
                else
                {
                    base.Konum += 2;
                }

            }
            else
            {
                if((base.Konum-4)>=0)
                {
                     base.Konum -= 4;

                }
                else
                {
                    base.Konum = 0;
                }
            }
            return base.Konum;
        }

        public Cakal(string isim,  int yarismaciNo , int yarismaPisti) : base(isim, yarismaciNo, yarismaPisti)
        {
            base.Isim = isim;
            base.YarismaciNo = yarismaciNo;
            base.yarismaPisti = yarismaPisti;
        }

   
    }
}
