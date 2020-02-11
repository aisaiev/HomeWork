using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Code_First_HomeWork_08_02.Model
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MaxLength(2)]
        public string CountryId { get; set; }

        [MaxLength(40)]
        public string CountryName { get; set; }


        public Region Region { get; set; }

        public IEnumerable<Location> Locations { get; set; }
    }
}
