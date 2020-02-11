using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Code_First_HomeWork_08_02.Model
{
    public class Region
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegionId { get; set; }

        [MaxLength(25)]
        public string RegionName { get; set; }


        public IEnumerable<Country> Countries { get; set; }
    }
}
