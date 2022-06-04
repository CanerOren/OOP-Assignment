using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pist
    {
        Random random = new Random();
        private int pist;
        public int PistUzunlugu { get; set; }

        public void DurumuYazdir(IYarismaci yarismaci)
        { 
            if(yarismaci.GetType()== typeof(Devekusu))
            {
                Devekusu devekusu = (Devekusu)yarismaci;
                if(devekusu.Paralize==true)
                {
                    Console.WriteLine("{0} paralize oldu.",yarismaci.Isim);
                }
                else
                {
                    Console.WriteLine("Konum:{0}", yarismaci.Konum);
                }
            }

            else
            {
                Console.WriteLine("Konum:{0}",yarismaci.Konum);
            }
        }

        public void KonumdakiYarismacilar(List<IYarismaci> yarismaciList)
        {
            foreach(var yarismaci in yarismaciList )
            {
                foreach(var yarismaci2 in yarismaciList )
                {
                    if((yarismaci2.Konum== yarismaci.Konum )&& (yarismaci2.Konum>0) && (yarismaci.Isim !=yarismaci2.Isim))
                    {
                     if((yarismaci.GetType()==typeof(Devekusu))&&(yarismaci2.GetType()==typeof(Cakal)))
                        {
                            int rng = random.Next(1, 101);

                            if ((rng > 0) && (rng <= 50))
                            {
                                Devekusu devekusu = (Devekusu)yarismaci;
                                if (devekusu.Paralize == false)
                                {
                                    devekusu.Paralize = true;
                                }
                            }
                            
                        }

                     if((yarismaci.GetType()==typeof(Devekusu)) && (yarismaci2.GetType()==typeof(MekanikFil)))
                        {
                            int rng = random.Next(1,101);

                            if((rng>0)&& (rng <=20))
                            {
                                Devekusu devekusu = (Devekusu)yarismaci;
                                if(devekusu.Paralize ==false)
                                {
                                    devekusu.Paralize=true;
                                }
                            }
                        }
                     if((yarismaci.GetType()==typeof(Cakal)) && (yarismaci2.GetType()==typeof(SalyanBot)))
                        {
                            int rng = random.Next(1,101);
                            if((rng>0)&& (rng <=25))
                            {
                                yarismaci.Konum -= 1;
                            }
                        }
                        if ((yarismaci.GetType() == typeof(Devekusu)) && (yarismaci2.GetType() == typeof(SalyanBot)))
                        {
                            int rng = random.Next(1, 101);
                            Devekusu devekusu =(Devekusu)yarismaci;
                            if((rng>0)&& (rng<=25))
                            {
                             if(devekusu.Paralize ==false)
                                {
                                    yarismaci.Konum -= 1;
                                }


                            }
                        }

                    }
                }
            }
        }

        public void KonumGuncelle(IYarismaci yarismaci)
        {
            Thread.Sleep(1);
            yarismaci.HareketEt();
           
            
        }

        public List<IYarismaci> YarismaciEkle(string yarismacilar,int count, int yarismaPisti)
        {
            List<IYarismaci> yarismaciList = new List<IYarismaci>();
            
          
            while (count > 0)
            {
                string line = yarismacilar.Split(new char[] { '\n' })[count - 1];
                string tur = line.Split(new char[] { ' ' })[2];
                string yarismaciNoCast = line.Split(new char[] { ' ' })[0];
                int yarismaciNo = int.Parse(yarismaciNoCast);
                string isim = line.Split(new char[] { ' ' })[1];

                if(tur=="CAKAL" || tur=="CAKAL\r")
                {
                
                    yarismaciList.Add(new Cakal(isim, yarismaciNo,yarismaPisti));
                }

                else if (tur == "DEVEKUSU" || tur == "DEVEKUSU\r")
                {
                    yarismaciList.Add(new Devekusu(isim, yarismaciNo, yarismaPisti));
                }

                else if (tur == "SALYANBOT" || tur == "SALYANBOT\r")
                {

                    yarismaciList.Add(new SalyanBot(isim, yarismaciNo, yarismaPisti));
                }

                else if (tur == "MEKANIKFİL" || tur == "MEKANIKFIL\r")
                {

                    yarismaciList.Add(new MekanikFil(isim, yarismaciNo, yarismaPisti));
                }
                count -= 1;

            }



            return yarismaciList;

        }


        public Pist(int pist,int pistUzunlugu)
        {
            this.pist = pist;
            PistUzunlugu = pistUzunlugu;
        }
    }
}
