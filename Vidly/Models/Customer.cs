﻿using System.Data.Entity;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }
    }
}