using FuneralCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuneralCRM.Services
{
    public interface IAccountatntRepository
    {
        Task<AccountatntDTO?> GetAsync(int id);
    }
}
