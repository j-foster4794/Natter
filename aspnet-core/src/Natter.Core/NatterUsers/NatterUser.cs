using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natter.NatterUsers
{
	[Table("NatterUsers")]
	public class NatterUser : Entity, IHasCreationTime
	{
		public DateTime CreationTime { get; set; }

        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public NatterUser()
        {
            CreationTime = Clock.Now;
        }

        public NatterUser(string firstname, string surname, string email, string username, string password) : this()
        {
            Firstname = firstname;
            Surname = surname;
            Email = email;
            Username = username;
            Password = password;
        }
    }
}
