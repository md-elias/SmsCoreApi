using SmsCoreApi.DAL.Interfaces;
using SmsCoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmsCoreApi.DAL.Repositories
{
    public class CountryRepository : IRepository<Country>
    {
        public Task<object> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Country>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Country> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<object> Post(Country entity)
        {
            throw new NotImplementedException();
        }

        public Task<object> Put(int id, Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
