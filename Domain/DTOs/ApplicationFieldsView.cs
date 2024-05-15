using ApplicationMgt.Models;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class ApplicationFieldsView
    {
        public string Id { get; set; }
        public string ProgramTitle { get; set; }
        public string ProgramDescription { get; set; }
        public List<FormField> Fields { get; set; }
        public List<CandidateQuestion> CustomQuestions { get; set; }
    }
}
