using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Address : IEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int CityId { get; set; }
        public char AddressDetail { get; set; }
        public char PostalCode { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
    }
}
