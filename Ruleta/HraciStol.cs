using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta
{
    public class HraciStol
    {
        public HraciePole[] Hraciepolicka = new HraciePole[37];
        public HraciStol()
        {
            Farba[] rozmiestnenieFarieb = new Farba[37] { Farba.zelena , Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna,
                Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena,
                Farba.cierna, Farba.cervena, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna,
                Farba.cervena, Farba.cierna, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena, Farba.cierna, Farba.cervena };

            for (int i = 0; i < rozmiestnenieFarieb.Length; i++)
            {
                Hraciepolicka[i].farba = rozmiestnenieFarieb[i];
                Hraciepolicka[i].cislo = i;
                Hraciepolicka[i].rada = vratRadu(i);
                Hraciepolicka[i].lichost = vratLichost(i);
           
            }
           
        }
        private Lichost vratLichost(int cislo)
        {
            if (cislo == 0) return Lichost.ziadna;
            if (cislo % 2 == 0) return Lichost.suda;
            return Lichost.licha;
        }
        private Rada vratRadu(int cislo)
        {
            if (cislo == 0) return Rada.ziadna;
            if (cislo == 1 || cislo - 1 % 3 == 0) return Rada.prva;
            if (cislo == 2 || cislo - 2 % 3 == 0) return Rada.druha;
            //if (cislo == 3 || cislo - 3 % 3 == 0) return Rada.tretia;
            return Rada.tretia;
        }
    }
}
