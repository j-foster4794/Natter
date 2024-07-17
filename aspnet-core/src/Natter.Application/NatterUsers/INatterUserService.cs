using Natter.NatterUsers.Dto;
using System.Threading.Tasks;

namespace Natter.NatterUsers
{
	public interface INatterUserService
	{
		Task<GetAllNatterUsersOutput> GetAllNatterUsers();
	}
}