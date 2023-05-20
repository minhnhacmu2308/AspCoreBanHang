﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHangCoreMcv.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }

        public int Discount { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}
