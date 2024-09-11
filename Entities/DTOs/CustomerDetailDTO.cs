using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CustomerDetailDTO:IDTO
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }

    }
}
