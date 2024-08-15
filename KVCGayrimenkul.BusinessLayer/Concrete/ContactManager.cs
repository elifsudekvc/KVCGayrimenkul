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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public void TDelete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public Contact TGetByID(int id)
        {
            return _contactDal.GetByID(id); 
        }

        public List<Contact> TGetListAll()
        {
            return _contactDal.GetListAll();
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
