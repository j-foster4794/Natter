using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Natter.NatterUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Natter.NatterInteractions;
using Microsoft.EntityFrameworkCore;

namespace Natter.Posts
{
    [Table("NatterPosts")]
	public class NatterPost: Entity, IHasCreationTime
	{

        public DateTime CreationTime { get; set; }

        public string Caption { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }


        [ForeignKey(nameof(NatterUserId))]

        public NatterUser NatterUser { get; set; }
        public int NatterUserId { get; set; }

    }
}
