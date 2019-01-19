﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name, ICollection<Seller> sellers)
        {
            Id = id;
            Name = name;
        }
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            // return Sellers.Where(dp => dp.BirthDate >= initial && dp.BirthDate >= final).Sum(dp => dp.BaseSalary);
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
