using ApplicationMgt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class ApplicationForm
    {
        [Key]
        public string Id { get; set; }
        public string ProgramTitle { get; set; }
        public string ProgramDescription { get; set; }
        public List<FormField> Fields { get; set; }
        public List<string> CustomQuestionIds { get; set; }
    }
}
