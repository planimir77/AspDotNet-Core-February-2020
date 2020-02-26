using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDMC.Web.Models.Home;

namespace FDMC.Web.Services
{
    public interface IGetAllCatsService
    {
        IndexViewModel GetAllCats();
    }
}
