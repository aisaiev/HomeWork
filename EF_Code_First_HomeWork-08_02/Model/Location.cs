using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Code_First_HomeWork_08_02.Model
{
    public class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationId { get; set; }

        [MaxLength(25)]
        public string StreetAddress { get; set; }

        [MaxLength(12)]
        public string PostalCode { get; set; }

        [MaxLength(30)]
        public string City { get; set; }

        [MaxLength(12)]
        public string StateProvince { get; set; }


        public Country Country { get; set; }

        public IEnumerable<Department> Departments { get; set; }
    }
}
