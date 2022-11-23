using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Data.EfCore.Abstract;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Concrete
{
    public class EfCoreKitapRepository : IKitapRepository
    {
        public List<Kitap> KitapListesi()
        {
            using (var context = new KitabeviContext())
            {
                return context.Kitaplar.ToList();
            }
        }
    }
}