using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natter.NatterPosts.Dtos
{
	public class GetAllNatterPostsOutput
	{
        public List<NatterPostDto> Posts { get; set; }
    }
}
