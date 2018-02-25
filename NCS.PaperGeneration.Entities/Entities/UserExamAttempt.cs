using NCS.PaperGeneration.Entities.CompactEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.Entities
{
    public class UserExamAttempt : UserExamAttemptCompact
    {
        public int Attempt { get; set; }
        public int Marks { get; set; }
        public bool PassofFail { get; set; }
        public Nullable<DateTime> ExamDate { get; set; }
        public byte Status { get; set; }
    }
}
