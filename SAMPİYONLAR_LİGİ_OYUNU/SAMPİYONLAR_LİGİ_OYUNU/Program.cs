using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO.Pipes;

namespace LİG_OYUNU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ŞAMPİYONLAR LİGİ YARI FİNAL AŞAMASI";
            Console.WriteLine("***********ŞAMPİYONLAR LİGİNE HOŞGELDİNİZ******");
            Console.WriteLine();
            Console.WriteLine("********** A GRUBU TAKIMLARI**********");
            Console.WriteLine("---------------------");
            Console.WriteLine("Bayern Münih");
            Console.WriteLine("Manchester United");
            Console.WriteLine("Galatasaray");
            Console.WriteLine("Kopenhag");
            Console.WriteLine("");
            Console.WriteLine("---------------------");

            Random rastgele = new Random();
            int BM = 0;
            int MU = 0;
            int GS = 0;
            int KG = 0;
            int sayac = 1;

            int bm1, bm2, bm3;
            int mu1, mu2, mu3;
            int gs1, gs2, gs3;
            int kg1, kg2, kg3;
            

            if (sayac == 1)
            {
                bm1 = rastgele.Next(0, 7);
                mu1 = rastgele.Next(0, 7);
                gs1 = rastgele.Next(0, 7);
                kg1 = rastgele.Next(0, 7);
                Console.WriteLine("1.Hafta Skorları");
                Console.WriteLine("----------------------");
                Console.WriteLine("Bayern Münih:" + bm1 + "-" + gs1 + "Galatasaray:");
                if (bm1 > gs1)
                {
                    BM += 3;
                }
                if (gs1 > bm1)
                {
                    GS += 3;
                }
                if (gs1 == bm1)
                {
                    GS += 1;
                    BM += 1;
                }
                Console.WriteLine("Manchester United:" + mu1 + "-" + kg1 + "Kopenhag:");
                if (mu1 > kg1)
                {
                    MU += 3;
                }
                if (kg1 > mu1)
                {
                    KG += 3;
                }
                if (kg1 == mu1)
                {
                    KG += 1;
                    MU += 1;
                }
                sayac++;


                Console.ReadLine();
            }
            if (sayac == 2)
            {
                bm2 = rastgele.Next(0, 7);
                mu2 = rastgele.Next(0, 7);
                gs2 = rastgele.Next(0, 7);
                kg2 = rastgele.Next(0, 7);
                Console.WriteLine("2.Hafta Skorları");
                Console.WriteLine("----------------------");
                Console.WriteLine("Kopenhag:" + kg2 + "-" + bm2 + ":Bayern Münih");
                if (kg2 > bm2)
                {
                    KG += 3;
                }
                if (bm2 > kg2)
                {
                    BM += 3;
                }
                if (kg2 == bm2)
                {
                    KG += 1;
                    BM += 1;
                }
                Console.WriteLine("Galatasaray:" + gs2 + "-" + mu2 + ":Manchester United");
                if (gs2 > mu2)
                {
                    GS += 3;
                }
                if (mu2 > gs2)
                {
                    MU += 3;
                }
                if (gs2 == mu2)
                {
                    GS += 1;
                    MU += 1;
                }
                sayac++;
                Console.ReadLine();

            }

            if (sayac == 3)
            {
                bm3 = rastgele.Next(0, 7);
                kg3 = rastgele.Next(0, 7);
                mu3 = rastgele.Next(0, 7);
                gs3 = rastgele.Next(0, 7);
                Console.WriteLine("3.Hafta Skorları");
                Console.WriteLine("----------------------");
                Console.WriteLine("Manchester United:" + mu3 + "-" + bm3 + ":Bayern Münih");
                if (mu3 > bm3)
                {
                    MU += 3;
                }
                if (bm3 > mu3)
                {
                    BM += 3;
                }
                if (bm3 == mu3)
                {
                    MU += 1;
                    BM += 1;
                }
                Console.WriteLine("Galatasaray:" + gs3 + "-" + kg3 + ":Kopenhag");
                if (gs3 > kg3)
                {
                    GS += 3;
                }
                if (kg3 > gs3)
                {
                    KG += 3;
                }
                if (kg3 == gs3)
                {
                    KG += 1;
                    GS += 1;
                }

                sayac++;
                Console.ReadLine();

            }
            
            if (sayac == 4)
            {
                Console.WriteLine("Sonuçlar");
                Console.WriteLine("----------------------");
                Console.WriteLine("TAKIMLAR\t PUANLAR");
                Console.WriteLine("Bayern Münih:     " +      BM  );
                Console.WriteLine("Galatsaray:       " +           GS );
                Console.WriteLine("Manchester United:" +    MU );
                Console.WriteLine("Kopenhag:         " +         KG  );
             
            }
           
            
            if (BM > MU && BM > KG && BM > GS)
            {
                Console.WriteLine("*********ŞAMPİYONLAR LİGİ ŞAMPİYONU BAYERN MÜNİH...*********");
               
            }
            if (MU > BM && MU > KG && MU > GS)
            {
                Console.WriteLine("*********ŞAMPİYONLAR LİGİ ŞAMPİYONU MANCHESTER UNİTED...*********");
               
            }
            if (GS > MU && GS > KG && GS > BM)
            {
                Console.WriteLine("*********ŞAMPİYONLAR LİGİ ŞAMPİYONU GALATASARAY...*********");
               
            }
            if (KG > MU && KG > BM && KG > GS)
            {
                Console.WriteLine("*********ŞAMPİYONLAR LİGİ ŞAMPİYONU KOPENHAG...*********");
                
            }
            if(GS==BM && KG==MU && GS==KG && BM==MU)
            {
                Console.WriteLine("Puanlar eşit olduğu için averaja bakılarak şampiyon belirlenecektir.");
                
            }
           
           

            Console.Read();



        }
    }
}


