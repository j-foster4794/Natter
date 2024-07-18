using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using Natter.Posts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Natter.NatterUsers;
using Microsoft.EntityFrameworkCore;

namespace Natter.NatterInteractions
{
    [Table("NatterInteractions")]
    public class NatterInteraction : Entity, IHasCreationTime
    {
        public DateTime CreationTime { get; set; }
        public string Type { get; set; }

        [ForeignKey(nameof(NatterUserId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public NatterUser NatterUser { get; set; }
        public int NatterUserId { get; set; }


    }
}
