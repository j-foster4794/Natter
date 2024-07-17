using Natter.EntityFrameworkCore;
using Natter.NatterUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Natter.Tests.TestData
{
	public class TestDataBuilder
	{
		private readonly NatterDbContext _dbContext;

		public TestDataBuilder(
			NatterDbContext dbContext)
		{
			_dbContext = dbContext;
		}


		public void Build()
		{

			_dbContext.NatterUsers.AddRange(
				new NatterUser("James", "Foster", "james@example.com", "JFoster", "Password123"),
				new NatterUser("Stew", "Speer", "stew@example.com", "SSpeer", "Password123")
			);

		}
	}
}
