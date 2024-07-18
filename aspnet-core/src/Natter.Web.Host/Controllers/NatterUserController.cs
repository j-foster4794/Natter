using Microsoft.AspNetCore.Mvc;
using Natter.Controllers;
using Natter.NatterUsers;
using Natter.NatterUsers.Dto;

namespace Natter.Web.Host.Controllers
{
    public class NatterUserController : NatterControllerBase
    {
        private readonly INatterUserService _userService;
        public NatterUserController(INatterUserService userService)
        {
            _userService = userService;
        }
        public GetUserByIdOutput GetUserById(GetUserByIdInput input)
        {
            var output = new GetUserByIdOutput();

            var response = _userService.GetUserById(new GetUserByIdInput() { UserId = input.UserId });

            output.NatterUser = response.NatterUser;

            return output;
        }
    }
}
