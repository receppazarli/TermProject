﻿using Comp337.Entities.Abstract;

namespace Comp337.Entities.Concrete
{
    public class Department : IEntity
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }

    }
}