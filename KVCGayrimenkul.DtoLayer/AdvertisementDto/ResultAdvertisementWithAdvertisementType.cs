﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVCGayrimenkul.DtoLayer.AdvertisementDto
{
    public class ResultAdvertisementWithAdvertisementType
    {
        public int AdvertisementID { get; set; }
        public string AdvertisementName { get; set; }
        public string Description { get; set; }
        public int SquareMeters { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool AdvertisementStatus { get; set; }
        public string AdvertisementTypeName { get; set; }
		public int AdvertisementTypeID { get; set; }
	}
}
