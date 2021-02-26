using SmsCoreApi.DAL.Interfaces;
using SmsCoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmsCoreApi.DAL.Repositories
{
    public class EmployeeRepositoy : IEmployeeRepository
    {
        public Task<object> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<object> Post(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<object> Put(int id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
