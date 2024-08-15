using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVCGayrimenkul.DtoLayer.MessageDto
{
    public class GetMessageDto
    {
        public int MessageID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string PersonMessage { get; set; }
    }
}
