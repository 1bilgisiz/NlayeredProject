using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLAyer;


namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPerosnelListesi()
        {
            return DALPersonel.PersonelListesi();
        }
        public static int LlPersonelEkle(EntityPersonel p)
        {
            if (p.Ad != "" && p.Soyad != "" && p.Maas >= 3500 && p.Ad.Length >= 3)
            {
                return DALPersonel.PersonelEkle(p);

            }
            else
            {
                return -1;

            }

        }


        public static bool LlPerosnelSil(int per)
        {
            if (per >= 1)
            {
                return DALPersonel.PersonelSil(per);

            }
            else
            { return false; }
        }

        public static bool LlPersonelGüncelle(EntityPersonel ent)
        {
            if (ent.Ad.Length>=3  &&  ent.Ad !="" && ent.Maas >= 3200)
            {
                return DALPersonel.PersonelGüncelle(ent);

            }
            else
            {
                return false;
            }
        }
    }
}
