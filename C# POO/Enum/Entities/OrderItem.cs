﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public Double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name + ", ");
            sb.Append("$"+Price + ", ");
            sb.Append("Quantity: " + Quantity.ToString("F2",CultureInfo.InvariantCulture) + ", ");
            sb.Append("Subtotal: " + SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();

        }
    }

}
