using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using Natter.NatterInteractions;
using Natter.NatterUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natter.NatterMessages
{
    [Table("NatterMessages")]
    public class NatterMessage : Entity, IHasCreationTime
    {

        public DateTime CreationTime { get; set; }


        
    }
}
