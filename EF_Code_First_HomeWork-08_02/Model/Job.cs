using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Code_First_HomeWork_08_02.Model
{
    public class Job
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MaxLength(10)]
        public string JobId { get; set; }

        [MaxLength(35)]
        public string JobTitle { get; set; }

        public decimal MinSalary { get; set; }

        public decimal MaxSalary { get; set; }


        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<JobHistory> JobHistories  { get; set; }
    }
}
