using ERPCore.AppDb;
using ERPCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPCore.Services
{
    public class SqliteEmployeeRepository : SqlEmployeeRepository
    {
        public readonly AppDbContext _DbContext;
        public SqliteEmployeeRepository(AppDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
