﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
      
        
    }
}
