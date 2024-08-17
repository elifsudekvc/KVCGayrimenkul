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
    public class AdvertisementTypeManager : IAdvertisementTypeService
    {
        private readonly IAdvertisementTypeDal _advertisementTypeDal;

        public AdvertisementTypeManager(IAdvertisementTypeDal advertisementTypeDal)
        {
            _advertisementTypeDal = advertisementTypeDal;
        }

        public void TAdd(AdvertisementType entity)
        {
            _advertisementTypeDal.Add(entity);
        }

        public void TDelete(AdvertisementType entity)
        {
            _advertisementTypeDal.Delete(entity);
        }

        public AdvertisementType TGetByID(int id)
        {
            return _advertisementTypeDal.GetByID(id);
        }

        public List<AdvertisementType> TGetListAll()
        {
            return _advertisementTypeDal.GetListAll();
        }

        public void TUpdate(AdvertisementType entity)
        {
            _advertisementTypeDal.Update(entity);
        }
    }
}
