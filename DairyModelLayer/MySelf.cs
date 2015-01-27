namespace DairyModelLayer
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    public class MySelf
    {
        [Key]
        public int MySelfID { get; set; }
        public string Name { get; set; }
        public DateTime Born { get; set; }
        public string ImageUrl { get; set; }

    }
}
