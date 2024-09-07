using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Logic.Interfaces.Services;
using Example.Storage.Database;
using Example.Storage.Models;
using Example.Logic.DtoModels.Filters;
using Microsoft.EntityFrameworkCore;

namespace Example.Logic.Services
{
    public class CenterService : ICenterService
    {
        public IQueryable<Center> GetCenterQueryble(DataContext dataContext, CenterFilterDto filter, bool asNoTracking)
        {
			IQueryable<Center> query = dataContext.Centers;

            if (asNoTracking)
                query = query.AsNoTracking();

            if (string.IsNullOrEmpty(filter.Code))
                query = query.Where(x => x.Code == filter.Code);

            return query;
        }
    }
}
