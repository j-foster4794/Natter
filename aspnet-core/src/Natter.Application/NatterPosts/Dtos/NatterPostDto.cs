using Abp.AutoMapper;
using Natter.NatterUsers;
using Natter.Posts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natter.NatterPosts.Dtos
{
	[AutoMapFrom(typeof(NatterPost))]
	[AutoMapTo(typeof(NatterPost))]
	public class NatterPostDto
	{
		public DateTime CreationTime { get; set; }

		public string Caption { get; set; }
		public string Description { get; set; }
		public string Images { get; set; }
		public NatterUser NatterUser { get; set; }
	}
}
