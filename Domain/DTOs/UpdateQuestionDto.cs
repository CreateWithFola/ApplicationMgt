using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class UpdateQuestionDto
    {
        public string? Id { get; set; }
        public int Type { get; set; }
        public string Text { get; set; }
        public int? MaxChoices { get; set; }
        public List<string>? Options { get; set; }
    }
}
