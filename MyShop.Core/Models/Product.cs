﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MyShop.Core.Models
{
    public class Product: BaseEntity
    {
        //public string Id { get; set; }

        [StringLength(20)]
        [DisplayName("Product name")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Range(0, 1000)]
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }

        //public Product()
        //{
        //    this.Id = Guid.NewGuid().ToString();
        //}
    }
}