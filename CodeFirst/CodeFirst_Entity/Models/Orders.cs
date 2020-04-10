﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst_Entity.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int? FkCustId { get; set; }
        public int? FkProdId { get; set; }

        public decimal? OrderAmount { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual Customer FkCust { get; set; }

        public virtual Products FkProd { get; set; }
    }
}
