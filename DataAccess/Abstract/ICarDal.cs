using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
        List<CarDetailDto> GetCarDetailsById(int carId);
        List<CarDetailDto> GetCarDetailsByColorId(int colorId);
        List<CarDetailDto> GetCarDetailsByBrandId(int brandId);
        List<CarDetailDto> GetCarDetailsByBrandAndColor(int brandId, int colorId);

    }
}
