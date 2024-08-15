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
    public class AdvertisementTypeManager : IAdvertisementService
    {
        private readonly IAdvertisementDal _advertisementTypeDal;

        public AdvertisementTypeManager(IAdvertisementDal advertisementDal)
        {
            _advertisementTypeDal = advertisementDal;
        }

        public void TAdd(Advertisement entity)
        {
            _advertisementTypeDal.Add(entity);
        }

        public void TDelete(Advertisement entity)
        {
            _advertisementTypeDal.Delete(entity);
        }

        public Advertisement TGetByID(int id)
        {
            return _advertisementTypeDal.GetByID(id);
        }

        public List<Advertisement> TGetListAll()
        {
            return _advertisementTypeDal.GetListAll();
        }

        public void TUpdate(Advertisement entity)
        {
            _advertisementTypeDal.Update(entity);
        }
    }
}
