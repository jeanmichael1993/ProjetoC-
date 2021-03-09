using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
