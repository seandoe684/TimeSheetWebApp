using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetWebApp.Models;

namespace TimeSheetWebApp.DAL
{
    public interface IPersonRepository
    {
        IQueryable<Person> People { get; }
    }
}
