﻿using KVCGayrimenkul.DataAccessLayer.Abstract;
using KVCGayrimenkul.DataAccessLayer.Concrete;
using KVCGayrimenkul.DataAccessLayer.Repositories;
using KVCGayrimenkul.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVCGayrimenkul.DataAccessLayer.EntityFramework
{
    public class EfAdvertisementTypeDal : GenericRepository<AdvertisementType>, IAdvertisementTypeDal
    {
        public EfAdvertisementTypeDal(KVCGayrimenkulContext context) : base(context)
        {
        }
    }
}
