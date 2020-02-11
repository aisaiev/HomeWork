using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Code_First_HomeWork_08_02.Model
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [MaxLength(20)]
        public string FirstName { get; set; }

        [MaxLength(25)]
        public string LastName { get; set; }

        [MaxLength(25)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        public DateTime HireDate { get; set; }

        public decimal Salary { get; set; }

        public int CommissionPct { get; set; }

        public int ManagerId { get; set; }


        public Department Department { get; set; }

        public Job Job { get; set; }

        public IEnumerable<JobHistory> JobHistories { get; set; }
    }
}
