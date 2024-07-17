using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natter.NatterUsers.Dto
{
	public class GetAllNatterUsersOutput
	{
		public List<NatterUserDto> NatterUsers { get; set; } = new();
    }
}
