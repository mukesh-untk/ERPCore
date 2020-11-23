using ERPCore.AppDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPCore.Services
{
    public class MSqlEmployeeRepository : SqlEmployeeRepository
    {
        public MSqlEmployeeRepository(AppDbContext DbContext) : base(DbContext)
        {

        }
    }
}
