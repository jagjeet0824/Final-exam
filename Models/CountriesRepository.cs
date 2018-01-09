using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2084FinalF2017.Models
{

    // repository for mock album data for unit testing
    public interface CountriesRepository
    {
        IQueryable<Country> Countries { get; }
        Country Save(Country Country);
        void Delete(Country Country);

    }
}

