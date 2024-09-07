using Example.Logic.DtoModels.Filters;
using Example.Storage.Database;
using Example.Storage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Logic.Interfaces.Services
{
    public interface ICenterService
    {
		IQueryable<Center> GetCenterQueryble(DataContext dataContext, CenterFilterDto filter, bool asNoTracking);

	}
}
