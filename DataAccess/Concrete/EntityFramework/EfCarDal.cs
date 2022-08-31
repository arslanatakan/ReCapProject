using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, AtaDataContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (AtaDataContext context = new AtaDataContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands                          
                             on c.BrandId equals b.BrandId
                             join k in context.Colors
                             on c.ColorId equals k.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice,
                                 ColorId = c.ColorId,
                                 BrandId = c.BrandId,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,
                                 ColorName = k.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
