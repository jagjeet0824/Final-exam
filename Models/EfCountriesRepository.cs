using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2084FinalF2017.Models
{
    public class EfCountriesRepository
    {
        Country db = new Country();

        public IQueryable<Country> Country { get { return db.Country; } }

        public void Delete(Country Country)
        {
            db.Country.Remove(Country);
            db.SaveChanges();
        }

        public Country Save(Country Country)
        {
            if (Country.medal == 0)
            {
                db.Countries.Add(Country);
            }
            else
            {
                db.Entry(Country).State = System.Data.Entity.EntityState.Modified;
            }

            db.SaveChanges();
            return Country;
        }
}