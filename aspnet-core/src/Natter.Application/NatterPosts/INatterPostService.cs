using Natter.NatterPosts.Dtos;
using System.Threading.Tasks;

namespace Natter.NatterPosts
{
	public interface INatterPostService
	{
		Task<GetAllNatterPostsOutput> GetAllNatterPosts();

		Task<CreateNewPostOutput> CreateNewPost(CreateNewPostInput input);
	}
}