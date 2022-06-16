using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace melo.Model
{
    public class book
    {
        [Key]
        public int book_id { get; set; }
        public string book_name { get; set; }
        public string book_writer { get; set; }
        public string book_subject { get; set; }
        public string book_page { get; set; }
        public string book_price { get; set; }
    }
}
