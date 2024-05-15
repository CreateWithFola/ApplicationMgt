using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class CandidateQuestion
    {
        [Key]
        public string Id { get; set; }
        public QuestionTypeEnum Type { get; set; }
        public string QuestionText { get; set; }
        public int? MaxChoices { get; set; }
        public List<string>? Choices { get; set; }
    }
}
