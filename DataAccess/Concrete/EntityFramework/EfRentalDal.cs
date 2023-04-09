using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapDbContext>, IRentalDal
    {
        public List<RentalDto> GetRentalDto()
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var result = from c in context.Customers
                             join r in context.Rentals
                             on c.CustomerId equals r.CustomerId
                             join u in context.Users
                             on c.UserId equals u.UserId
                             join car in context.Cars
                             on r.CarId equals car.CarId
                             select new RentalDto
                             {
                                 CarId=car.CarId, CarName=car.CarName, 
                                 UserId=u.UserId, FirstName=u.FirstName, LastName=u.LastName, Email = u.Email,
                                 CustomerId = c.CustomerId, CompanyName=c.CompanyName,
                                 RentDate=r.RentDate, ReturnDate=r.ReturnDate, Id=r.Id,
                             };
                return result.ToList();
            }
       }
        
    }
}
