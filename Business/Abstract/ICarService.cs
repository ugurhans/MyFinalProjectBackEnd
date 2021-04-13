using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int ColorId);
        IDataResult<List<CarDetailDto>> GetCarsDetailByBrandId(int BrandId);
        IDataResult<List<CarDetailDto>> GetCarDetail();
        IDataResult<List<CarDetailDto>> GetCarDetailByCarId(int carId);

        IDataResult<List<CarDetailDto>> GetbyBrandIdandColorId(int brandId, int colorId);

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetById(int id);
        IDataResult<List<Car>> GetAll();

    }
}
