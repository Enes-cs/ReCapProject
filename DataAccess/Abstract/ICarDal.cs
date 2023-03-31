﻿using Entities.Concrete;

namespace DataAccess.Abstract

{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<Dto> GetCarDetails();
        
    }
}