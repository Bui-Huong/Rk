﻿namespace WebApplication1.Models
{
    public class UpdateEmployeeViewModel
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Salary { get; set; }
        public DateTime DateOfBith { get; set; }
        public string Department { get; set; }
    }
}
