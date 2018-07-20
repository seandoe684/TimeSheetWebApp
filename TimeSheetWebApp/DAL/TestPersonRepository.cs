using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetWebApp.Models;

namespace TimeSheetWebApp.DAL
{
    public class TestPersonRepository : IPersonRepository
    {
        public IQueryable<Person> People => new List<Person>
        {
            new Person {firstName="Aaron", lastName="Lealofi", middleName="Nahshon",
            dateOfBirth=Convert.ToDateTime("04-20-2014"), department="Housekeeping"},
            new Person {firstName="Micheal", lastName="Jordan", middleName="Byron",
            dateOfBirth=Convert.ToDateTime("11-20-1973"), department="Medical Staff"},
            new Person {firstName="James", lastName="Bond",
                middleName="Earl",dateOfBirth = Convert.ToDateTime("07-15-1962"),department="Executive"}
        }.AsQueryable<Person>();


    }
}
