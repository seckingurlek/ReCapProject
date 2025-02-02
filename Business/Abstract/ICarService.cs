﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<CarDetailDTO>> GetCarDetails(Car car);
        IDataResult <List<Car>> GetAll();
        IDataResult <List<Car>> GetCarsByBrandId(int brandId);
        IDataResult <List<Car>> GetCarsByColorId(int colorId);
        IResult  Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
