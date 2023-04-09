using Entities.Concrete;
using Entities.Concrete.Dto;

namespace DataAccess.Abstract

{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDto> GetCarDetails();
        
    }
}