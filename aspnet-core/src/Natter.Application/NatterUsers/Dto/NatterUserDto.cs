using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natter.NatterUsers.Dto
{
	[AutoMapFrom(typeof(NatterUser))]
	[AutoMapTo(typeof(NatterUser))]
	public class NatterUserDto: EntityDto, IHasCreationTime
	{
		public DateTime CreationTime { get; set; }

		public string Firstname { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
