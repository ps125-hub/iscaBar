﻿using iscaBar.Model;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace iscaBar.Models
{
    public class CategoryProduct : ModelBase
    {
        private int productId;
        private int categoryId;
        [ForeignKey(typeof(Product))]
        public int ProductId { get { return productId; } set { productId = value; OnPropertyChanged(); } }

        [ForeignKey(typeof(Category))]
        public int CategoryId { get { return categoryId; } set { categoryId = value; OnPropertyChanged(); } }
    }
}
