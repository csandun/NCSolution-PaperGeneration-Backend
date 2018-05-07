using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCS.PaperGeneration.Entities.CompactEntities;

namespace NCS.PaperGeneration.Entities.Entities
{
    public class UserExamAttemptQuestion : UserExamAttemptQuestionCompact
    {
        public bool IsAnswered { get; set; }
        public virtual Question Question { get; set; }
    }

    public class QuestionAnswer
    {
        public int ExamId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
    }
}
