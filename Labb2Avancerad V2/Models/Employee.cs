﻿namespace Labb2_Avancerad.Models
{
    public class Employee
    {

        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string?    PhoneNumber { get; set; }
        public string? Gender { get; set; }


        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public string? Adress { get; set; }
        public decimal? Salary { get; set; }





    }
}
