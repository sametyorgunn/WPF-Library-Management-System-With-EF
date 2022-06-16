using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace melo.Model
{
    public class author
    {
        [Key]
        public int author_id { get; set; }
        public string author_name { get; set; }
        public string author_age { get; set; }
        public string author_life { get; set; }
        public string author_books { get; set; }
    }
}
