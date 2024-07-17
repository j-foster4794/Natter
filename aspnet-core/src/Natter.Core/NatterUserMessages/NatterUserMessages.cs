using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Natter.NatterUsers;
using Natter.NatterMessages;

namespace Natter.NatterUserMessages
{
    [Table("NatterUserMessages")]
    public class NatterUserMessage : Entity, IHasCreationTime
    {

        public DateTime CreationTime { get; set; }

        [ForeignKey(nameof(SentFromUserId))]

        public NatterUser SentFromUserIds { get; set; }
        public int SentFromUserId { get; set; }

        [ForeignKey(nameof(NatterMessageId))]

        public NatterMessage NatterMessage { get; set; }

        public int NatterMessageId { get; set; }
        public int SentToUserId { get; set; } 

    }
}
