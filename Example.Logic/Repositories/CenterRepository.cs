using Example.Logic.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Storage.Models;
using Microsoft.EntityFrameworkCore.Storage;
using Example.Storage.Database;
using System.Text.Json.Nodes;
using Microsoft.EntityFrameworkCore;

namespace Example.Logic.Repositories
{
    public class CenterRepository : ICenterRepository
    {
        public Center Create(DataContext dataContext, Center center)
        {
            center.IsnNode = Guid.NewGuid();
            dataContext.Centers.Add(center);

            return center;
        }

        public Center Update(DataContext dataContext, Center center)
        {
            var centerDb = dataContext.Centers.FirstOrDefault(x => x.IsnNode == center.IsnNode)
                ?? throw new Exception($"Центр с индентификатором {center.IsnNode} не найден");

            centerDb.Code = center.Code;
            centerDb.Name = center.Name;

            return centerDb;
        }

        public void Delete(DataContext dataContext, Guid isnNode)
        {
			var centerDb = dataContext.Centers.FirstOrDefault(x => x.IsnNode == isnNode)
				?? throw new Exception($"Центр с индентификатором {isnNode} не найден");

            dataContext.Centers.Remove(centerDb);
		}

        public Center GetById(DataContext dataContext, Guid isnNode)
        {
            var centerDb = dataContext.Centers.AsNoTracking().FirstOrDefault(x => x.IsnNode == isnNode)
                ?? throw new Exception($"Центр с идентификатором {isnNode} не найден");

            return centerDb;
        }
    }
}
