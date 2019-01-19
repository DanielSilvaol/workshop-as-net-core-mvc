﻿using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus MyProperty { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus myProperty, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            MyProperty = myProperty;
            Seller = seller;
        }

        public SalesRecord()
        {
        }
    }
}
