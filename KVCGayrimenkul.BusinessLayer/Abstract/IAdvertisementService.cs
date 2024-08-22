using KVCGayrimenkul.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVCGayrimenkul.BusinessLayer.Abstract
{
    public interface IAdvertisementService:IGenericService<Advertisement>
    {
        List<Advertisement> TGetAdvertisementsWithCategories();

        List<Advertisement> TGetAdvertisementsWithAdvertisementTypes();
    }
}
