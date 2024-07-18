using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using Natter.NatterUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Natter.Posts;
using Natter.NatterInteractions;

namespace Natter.NatterPostInteractions
{
    [Table("NatterPostsInteractions")]
    public class NatterPostInteraction : Entity, IHasCreationTime
    {
        public DateTime CreationTime { get; set; }

        [ForeignKey(nameof(NatterPostId))]
        public NatterPost NatterPost { get; set; }
        public int NatterPostId { get; set; }

        [ForeignKey(nameof(NatterInteractionId))]

        public NatterInteraction NatterInteraction { get; set; }

        public int NatterInteractionId { get; set; }
        
    }
}
