﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Storage.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Example.Storage.MS_SQL
{
	public class SqlServerContextFactory : IDesignTimeDbContextFactory<DataContext>
	{

		private const string DbContextString = "Server=localhost,1433;Database=Example;User ID=sa;Password=asidasRERE1mfaie!23;MultipleActiveResultSets=true;TrustServerCertificate=True";

		public DataContext CreateDbContext(string[] args)
		{
			var optionBuilder = new DbContextOptionsBuilder<DataContext>();

			optionBuilder.UseSqlServer(DbContextString, b => b.MigrationsAssembly(typeof(SqlServerContextFactory).Namespace));

			return new DataContext(optionBuilder.Options);
		}
	}
}
