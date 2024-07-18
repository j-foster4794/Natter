using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Natter.NatterUsers.Dto;
using Microsoft.EntityFrameworkCore;

namespace Natter.NatterUsers
{
	public class NatterUserService : NatterAppServiceBase, INatterUserService
	{

		private readonly IRepository<NatterUser> _natterUserRepo;

		public NatterUserService(
			IRepository<NatterUser> natterUserRepo
		)
		{
			_natterUserRepo = natterUserRepo;
		}


		public async Task<GetAllNatterUsersOutput> GetAllNatterUsers()
		{
			var output = new GetAllNatterUsersOutput();

			var natterUsers = await _natterUserRepo.GetAll().ToListAsync();

			output.NatterUsers = ObjectMapper.Map<List<NatterUserDto>>(natterUsers);

			return output;
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public  GetUserByIdOutput GetUserById(GetUserByIdInput input)
		{
			var output = new GetUserByIdOutput();

			var natterUser = _natterUserRepo.GetAll().Where(u => u.Id==input.UserId).FirstOrDefault();

			output.NatterUser = ObjectMapper.Map<NatterUserDto>(natterUser);

			return output;
		}
	}
}
