using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuneralCRM.DataBase;
using FuneralCRM.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;


namespace FuneralCRM.Models
{
    public class AccountatntSqlServerRepository : IAccountatntRepository
    {
        private readonly FuneralCRMContext _dataBaseContext;
        public AccountatntSqlServerRepository(FuneralCRMContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        public async Task<AccountatntDTO?> GetAsync(int id)
        {
            return await (from User in _dataBaseContext.Users
                          select new AccountatntDTO
                          {
                              ID = User.UserId,
                              Image = User.Avatar,
                              Name = User.Username
                          }).FirstOrDefaultAsync(p=>p.ID == id);
        }

    }
}
