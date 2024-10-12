using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Core.Utilities;
using Business.Constants;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
           
        }

        public IResult Add(Car car)
        {

            if (car.Description.Length <=2&& car.DailyPrice < 0)
            {
               return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Add(car);
             return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            //iş kodları
           return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarAdded);
           
        }

        public IDataResult<List<CarDetailDTO>> GetCarDetails(Car car)
        {
                return new SuccessDataResult<List<CarDetailDTO>>(_carDal.GetCarDetails());
            
        }

        public IDataResult <List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.ColorId == colorId));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
