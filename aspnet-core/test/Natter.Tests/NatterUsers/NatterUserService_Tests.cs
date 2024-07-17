using Natter.NatterUsers;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Natter.Tests.NatterUsers
{
	public class NatterUserService_Tests : NatterTestBase
	{

		private readonly INatterUserService _natterUserService;

		public NatterUserService_Tests()
		{
			_natterUserService = Resolve<INatterUserService>();
		}

		[Fact]
		public async void ShouldGetAllNatterUsers()
		{

			var output = await _natterUserService.GetAllNatterUsers();

			output.NatterUsers.Count.ShouldBe(2);

		}

	}
}
