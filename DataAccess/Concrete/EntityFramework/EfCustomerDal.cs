using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer,ReCapDBContext>, ICustomerDal
    {
        public List<CustomerDetailDTO > GetCustomerDetails()
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from c in context.Customers
                             join u in context.Users on c.UserId equals u.UserId
                             select new CustomerDetailDTO
                             {
                                 UserId = u.UserId,
                                 CompanyName = c.CompanyName
                             };
                return result.ToList();
            }
        }
        
    }
}
