using NCS.PaperGeneration.Entities.CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.CompactEntities
{
    public class UserExamAttemptCompact : AuditableEntity<int>
    {
        public int ExamId { get; set; }
        public int LoginUserId { get; set; }
    }
}
