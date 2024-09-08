using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal :EfEntityRepositoryBase<Car, ReCapDBContext> ,ICarDal
    {
        public List<CarDetailDTO> GetCarDetails()
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors on c.ColorId equals co.ColorId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             
                             select new CarDetailDTO {
                                 Id = c.Id, BrandName = b.BrandName,
                                 ColorName = co.ColorName, ModelYear = c.ModelYear,DailyPrice = c.DailyPrice, Description = c.Description
                                 
                             };
                return result.ToList();
                                 
            }
        }
    
    }
}
