using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class CreateQuestionDto
    {
        public QuestionTypeEnum Type { get; set; }
        public string Text { get; set; }
        public int? MaxChoices { get; set; }
        public List<string>? Choices { get; set; }
    }
}
