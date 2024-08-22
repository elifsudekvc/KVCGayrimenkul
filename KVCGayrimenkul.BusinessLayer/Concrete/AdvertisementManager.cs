using KVCGayrimenkul.BusinessLayer.Abstract;
using KVCGayrimenkul.DataAccessLayer.Abstract;
using KVCGayrimenkul.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVCGayrimenkul.BusinessLayer.Concrete
{
    public class AdvertisementManager : IAdvertisementService
    {
        private readonly IAdvertisementDal _advertisementDal;

        public AdvertisementManager(IAdvertisementDal advertisementDal)
        {
            _advertisementDal = advertisementDal;
        }

        public void TAdd(Advertisement entity)
        {
            _advertisementDal.Add(entity);
        }

        public void TDelete(Advertisement entity)
        {
            _advertisementDal.Delete(entity);
        }

        public List<Advertisement> TGetAdvertisementsWithAdvertisementTypes()
        {
            return _advertisementDal.GetAdvertisementsWithAdvertisementTypes();
        }

        public List<Advertisement> TGetAdvertisementsWithCategories()
        {
            return _advertisementDal.GetAdvertisementsWithCategories();
        }

        public Advertisement TGetByID(int id)
        {
            return _advertisementDal.GetByID(id);
        }

        public List<Advertisement> TGetListAll()
        {
            return _advertisementDal.GetListAll();
        }

        public void TUpdate(Advertisement entity)
        {
            _advertisementDal.Update(entity);
        }
    }
}
