using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVCGayrimenkulWebUI.Dtos.AdvertisementTypeDtos
{
    public class GetAdvertisementTypeDto
    {
        public int AdvertisementTypeID { get; set; }
        public string AdvertisementTypeName { get; set; }
        public bool AdvertisementTypeStatus { get; set; }
    }
}
