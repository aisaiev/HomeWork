using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Code_First_HomeWork_08_02.Model
{
    public class JobHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


        public Department Department { get; set; }

        public Job Job { get; set; }

        public Employee Employee { get; set; }
    }
}
