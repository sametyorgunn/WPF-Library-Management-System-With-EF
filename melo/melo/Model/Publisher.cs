using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace melo.Model
{
    public class Publisher
    {
        [Key]
        public int publisher_id { get; set; }
        public string publishername { get; set; }
        public string publisherphone { get; set; }
        public string publishermail { get; set; }
    }
}
