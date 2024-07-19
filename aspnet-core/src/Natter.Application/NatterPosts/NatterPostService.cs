using Abp.Domain.Repositories;
using Castle.Core.Logging;
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
		private readonly ILogger _logger;

		public NatterPostService(
			IRepository<NatterPost> natterPostRepo,
			ILogger logger
		)
		{
			_natterPostRepo = natterPostRepo;
			_logger = logger;
		}


		public async Task<GetAllNatterPostsOutput> GetAllNatterPosts()
		{

			var output = new GetAllNatterPostsOutput();

			var posts = await _natterPostRepo.GetAll().ToListAsync();

			output.Posts = ObjectMapper.Map<List<NatterPostDto>>(posts);

			return output;

		}


		/// <summary>
		/// Create a new post
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task<CreateNewPostOutput> CreateNewPost(CreateNewPostInput input)
		{
			var output = new CreateNewPostOutput();

			try
			{
				var newPost = new NatterPost()
				{
					Caption = input.NatterPost.Caption,
					Description = input.NatterPost.Description,
					Images = input.NatterPost.Images != null ? input.NatterPost.Images : "",
					NatterUserId = input.UserId
				};
				var result =  _natterPostRepo.Insert(newPost);

				output.PostId = result.Id;
			}
			catch (Exception ex)
			{

				_logger.Error("Error creating a new post.", ex);

			}

			return output;

		}

	}


	public class CreateNewPostInput
	{

        public NatterPostDto NatterPost { get; set; }
		public int UserId { get; set; }

	}

	public class CreateNewPostOutput
	{
        public int PostId { get; set; }
    }
}
