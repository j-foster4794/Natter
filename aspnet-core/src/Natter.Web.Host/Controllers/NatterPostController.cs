using Microsoft.AspNetCore.Mvc;
using Natter.Controllers;
using Natter.NatterPosts;
using Natter.NatterPosts.Dtos;
using System.Threading.Tasks;

namespace Natter.Web.Host.Controllers
{
	public class NatterPostController : NatterControllerBase
	{

		private readonly INatterPostService _natterPostService;

		public NatterPostController(INatterPostService natterPostService)
		{
			_natterPostService = natterPostService;
		}


		/// <summary>
		/// Get all of the natter posts
		/// </summary>
		/// <returns></returns>
		public async Task<GetAllNatterPostsOutput> GetAllNatterPosts()
		{
			var output = new GetAllNatterPostsOutput();

			var response = await _natterPostService.GetAllNatterPosts();

			output.Posts = response.Posts;

			return output;
		}


		/// <summary>
		/// Create a new post
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task<CreateNewPostOutput> CreateNewPost([FromBody]CreateNewPostInput input)
		{

			var response = await _natterPostService.CreateNewPost(input);

			return response;

		}

	}
}
