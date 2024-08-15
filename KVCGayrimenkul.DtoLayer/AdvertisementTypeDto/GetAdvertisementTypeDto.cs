using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVCGayrimenkul.DtoLayer.AdvertisementTypeDto
{
    public class GetAdvertisementTypeDto
    {
        public int AdvertisementTypeID { get; set; }
        public string AdvertisementTypeName { get; set; }
        public bool AdvertisementTypeStatus { get; set; }
    }
}
