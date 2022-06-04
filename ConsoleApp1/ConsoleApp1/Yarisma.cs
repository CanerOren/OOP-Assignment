using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Yarisma
    {
        private string yarismacilar;

        private int yarismaPisti;

        List<IYarismaci> fullList;

        public void Baslat()
        {

            Pist pist1 = new Pist(1,yarismaPisti);
            int count = 1;

            for (int i = 0; i < yarismacilar.Length; i++)
            {
                if (yarismacilar[i] == '\n')
                {
                    count++;
                }
            }

            
             fullList= pist1.YarismaciEkle(yarismacilar,count,yarismaPisti);

            int konumMax = 0;
            int roundCount = 1;
            

            while(konumMax<=yarismaPisti-1)
            {
                int countTemp = count - 1;
                while(countTemp>=0)
                {
                    pist1.KonumGuncelle(fullList[countTemp]);
                    countTemp -= 1;
                }
                countTemp = count - 1;

                foreach (var yarismaci in fullList)
                {
                    if(yarismaci.Konum>konumMax)
                    {
                        konumMax = yarismaci.Konum;
                    }
                }

                pist1.KonumdakiYarismacilar(fullList);
                roundCount++;
            }
            
       
      
           
        }
        
      

           
            
           
        


        public void KonumlariYazdir()
        {
            var yarismacilarSiralanmis = from yarismaci in fullList
                                         orderby yarismaci.Konum
                                         select yarismaci;
            foreach(var yarismaci in yarismacilarSiralanmis)
            {
                Console.WriteLine("{0}  :: {1}, {2}",yarismaci.Konum,yarismaci.YarismaciNo,yarismaci.Isim);
            }
        }

        public Yarisma(string yarismacilar,int pistUzunlugu)
        {
            this.yarismacilar = File.ReadAllText(yarismacilar);
            this.yarismaPisti = pistUzunlugu;
        }
    }
}
