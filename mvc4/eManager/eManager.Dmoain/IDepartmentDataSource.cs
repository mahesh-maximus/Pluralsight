﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManager.Dmoain
{
    public interface IDepartmentDataSource
    {
        IQueryable<Employee> Employees { get; }
        IQueryable<Department> Departments { get; }
    }
}
