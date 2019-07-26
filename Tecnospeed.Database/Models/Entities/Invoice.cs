using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiterateElephant.Common.Model
{
    public class Invoice
    {
        public int Id { get; set; }

        public string Lot { get; set; }
        public string Number { get; set; }
        public DateTime GenerationDate { get; set; }
        public string Status { get; set; }
        public string Xml { get; set; }
        public string Handle { get; set; }
    }
}
