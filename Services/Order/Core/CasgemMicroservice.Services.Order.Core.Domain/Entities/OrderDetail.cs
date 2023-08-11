﻿namespace CasgemMicroservice.Services.Order.Core.Domain.Entities
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductAmount { get; set; }
        public int OrderID { get; set; }
        public Order Orders { get; set; }
    }
}
