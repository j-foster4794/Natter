﻿using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Natter.NatterUsers;
using Natter.NatterMessages;
using Microsoft.EntityFrameworkCore;

namespace Natter.NatterUserMessages
{
    [Table("NatterUserMessages")]
    public class NatterUserMessage : Entity, IHasCreationTime
    {

        public DateTime CreationTime { get; set; }

        [ForeignKey(nameof(SentFromUserId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]

        public NatterUser SentFromUser { get; set; }
        public int SentFromUserId { get; set; }

        [ForeignKey(nameof(NatterMessageId))]


        public NatterMessage NatterMessage { get; set; }

        public int NatterMessageId { get; set; }

        [ForeignKey(nameof(SentToUserId))]

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public NatterUser SentToUser { get; set; }

        public int SentToUserId { get; set; } 

    }
}
