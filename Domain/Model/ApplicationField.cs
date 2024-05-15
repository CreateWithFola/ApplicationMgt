using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class ApplicationField
    {
        public string FieldName { get; set; }
        public bool IsHidden { get; set; }
        public bool Internal { get; set; }
    }
}
