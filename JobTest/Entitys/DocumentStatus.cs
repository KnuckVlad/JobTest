using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTest.Entitys
{
    public class DocumentStatus
    {
        public int DocumentStatusId { get; set; }
        public int DocumentId { get; set; }
        public int StatusId { get; set; }
        public DateTime DateTime { get; set; }
    }
}
