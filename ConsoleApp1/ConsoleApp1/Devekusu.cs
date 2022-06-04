using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Devekusu:Hayvan
    {
        public bool Paralize{ get; set; }
        public override int HareketEt()
        {
            base.rng = new Random().Next(1, 101);
            if(Paralize==false)
            {

                if (base.rng > 0 && base.rng <= 50)
                {
                    if ((base.Konum + 3) >= base.yarismaPisti)
                    {
                        base.Konum = base.yarismaPisti;
                    }
                    else
                    {
                        base.Konum += 3;
                    }
                }
                else if (base.rng < 50 && base.rng <= 70)
                {
                    if ((base.Konum + 6) >= base.yarismaPisti)
                    {
                        base.Konum = base.yarismaPisti;
                    }
                    else
                    {
                        base.Konum += 6;
                    }

                }
                else
                {
                    if ((base.Konum - 4) >= 0)
                    {
                        base.Konum -= 4;
                    }
                    else
                    {
                        base.Konum = 0;
                    }

                }

            }
            return base.Konum;
        }

        public Devekusu(string isim ,int yarismaciNo, int yarismaPisti) : base(isim, yarismaciNo,yarismaPisti)
        {
            base.Isim = isim;
            base.YarismaciNo = yarismaciNo;
            base.yarismaPisti = yarismaPisti;
            Paralize = false;
            
        }
    }
}
