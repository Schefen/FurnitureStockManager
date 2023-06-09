﻿using Furniture.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.Entities.Concrete
{

    public class Product : IEntity
    {
        [Key]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string ProductName { get; set; }
        public Decimal UnitPrice { get; set; }
        public int QuantityPerUnit { get; set; }

    }
}
