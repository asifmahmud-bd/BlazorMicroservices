﻿using System;
namespace Basket.API.Entities
{
    public class ShoppingCartItem
    {
        public string ProductId { get; set; }
        public string Sku { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        
    }
}
