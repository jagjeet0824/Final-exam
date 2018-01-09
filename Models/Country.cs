namespace COMP2084FinalF2017.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class Country
    {
        internal int medal;

        public int CountryID { get; set; }

        [Column("Country")]
        [Required]
        [StringLength(50)]
        public string country { get; set; }

        public int Gold { get; set; }
        

        public int Silver { get; set; }

        public int Bronze { get; set; }

        public int TotalMedals { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        [Required]
        [StringLength(100)]
        public string Flag { get; set; }
        public IQueryable<Country> Countries { get; internal set; }

        internal object Entry(Country country)
        {
            throw new NotImplementedException();
        }
    }
}
