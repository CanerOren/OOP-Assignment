using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MekanikFil:Robot
    {
        
        public override int HareketEt()
        {

            base.rng = new Random().Next(1, 101);
           
            if (rng > 0 && rng <= 40)
            {
                if((base.Konum+2)>= base.yarismaPisti)
                {
                    base.Konum=base.yarismaPisti;
                }

                else
                {
                    base.Konum += 2;
                }
            }
            else if (rng > 40 && rng <= 50)
            {
                if((base.Konum+3)>= base.yarismaPisti)
                {
                    base.Konum = base.yarismaPisti;
                }
                else
                {
                    base.Konum += 3;
                }
            }

            else
            {
                base.Konum += 0;
            }

            return base.Konum;
        }
        public MekanikFil(string isim, int yarismaciNo , int yarismaPisti):base(isim,yarismaciNo,yarismaPisti) 
        {
            base.Isim = isim;
            
            base.YarismaciNo = yarismaciNo;

            base.yarismaPisti = yarismaPisti;
        }

        public void yazdir(MekanikFil mekanikfil)
        {
            Console.WriteLine(mekanikfil.Isim);
            
            Console.WriteLine(mekanikfil.YarismaciNo);
            Console.WriteLine(mekanikfil.Konum);
        }
    }
}
