using KVCGayrimenkul.DataAccessLayer.Abstract;
using KVCGayrimenkul.DataAccessLayer.Concrete;
using KVCGayrimenkul.DataAccessLayer.Repositories;
using KVCGayrimenkul.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVCGayrimenkul.DataAccessLayer.EntityFramework
{
    public class EfAdvertisementDal : GenericRepository<Advertisement>, IAdvertisementDal
    {
        public EfAdvertisementDal(KVCGayrimenkulContext context) : base(context)
        {
        }

        public List<Advertisement> GetAdvertisementsWithAdvertisementTypes()
        {
            var context = new KVCGayrimenkulContext();
            var values = context.Advertisements.Include(x => x.AdvertisementType).ToList();
            return values;
        }

        public List<Advertisement> GetAdvertisementsWithCategories()
        {
            var context = new KVCGayrimenkulContext();
            var values=context.Advertisements.Include(x=>x.Category).ToList();
            return values;
        }
    }
}
