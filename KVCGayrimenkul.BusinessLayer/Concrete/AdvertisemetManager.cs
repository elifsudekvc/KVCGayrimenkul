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
    public class AdvertisemetManager : IAdvertisementService
    {
        private readonly IAdvertisementDal _advertisementDal;

        public AdvertisemetManager(IAdvertisementDal advertisementDal)
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
