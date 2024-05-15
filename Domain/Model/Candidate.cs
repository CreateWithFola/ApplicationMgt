using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Candidate
    {
        public string Id { get; set; }
        public string ApplicationFormId { get; set; }
        public Dictionary<string, string> FieldResponses { get; set; } //FormFieldId, FieldResponse
        public Dictionary<string, List<string>> QuestionResponses { get; set; } //QuestionId, QuestionResponse
    }
}
