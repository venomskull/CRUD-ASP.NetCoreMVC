﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcAspCoreCrud.Models
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> opt): base(opt)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
