using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;


namespace Entities.Concrete
{
    public class Product : IEntity   // public koyduk satır başına çünkü public koyunca bu classa diğer katmanlarda(business,dataaccsess,consoleuı) ulaşabilir.
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
