using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Portfollio
    {
        [Key]
        public int PortfollioID { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageUrl2 { get; set; }
        public string? ProjectUrl { get; set; }
    }
}
