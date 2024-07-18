using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Natter.NatterPosts.Dtos;
using Natter.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natter.NatterPosts
{
	public class NatterPostService : NatterAppServiceBase, INatterPostService
	{

		private readonly IRepository<NatterPost> _natterPostRepo;

		public NatterPostService(
			IRepository<NatterPost> natterPostRepo
		)
		{
			_natterPostRepo = natterPostRepo;
		}


		public async Task<GetAllNatterPostsOutput> GetAllNatterPosts()
		{

			var output = new GetAllNatterPostsOutput();

			var posts = await _natterPostRepo.GetAll().ToListAsync();

			output.Posts = ObjectMapper.Map<List<NatterPostDto>>(posts);

			return output;

		}

	}
}
