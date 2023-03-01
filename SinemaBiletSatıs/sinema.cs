using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletSatıs
{
    public class sinema
    {
        
        
            int toplamKoltukSayisi;
            int bosKoltukSayisi;
            double bakiye;
            string salonNo;

            const double TAM = 100.0;
            const double INDIRIMLI = 75.0;

            public sinema(string salonn, int koltuksayi)
            {
                toplamKoltukSayisi = koltuksayi;
                salonNo = salonn;
                bosKoltukSayisi = toplamKoltukSayisi;
                bakiye = 0;

            }

            public void BiletSat(bool indirimli)
            {
                bosKoltukSayisi--;
                if (indirimli)
                    bakiye += INDIRIMLI;
                else
                    bakiye += TAM;
            }

            public void BiletIptal(bool indirimli)
            {
                bosKoltukSayisi++;
                if (indirimli)
                    bakiye -= INDIRIMLI;
                else
                    bakiye -= TAM;
            }

            public int BosKoltukOgren() 
            {
                return bosKoltukSayisi;
            }

            public double BakiyeOgren() 
            {
                return bakiye;
            }
    }
}
