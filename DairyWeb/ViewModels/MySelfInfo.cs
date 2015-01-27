namespace DairyWeb.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using DairyWeb.Infrastructure;
    using DairyModelLayer;
    using System.ComponentModel.DataAnnotations;
    public class MySelfInfo: IMapFrom<MySelf>
    {
        public int MySelfID { get; set; }
        [Required(ErrorMessage="Моля,въведете име!")]
        public string Name { get; set; }
        public DateTime Born { get; set; }
        public string ImageUrl { get; set; }
    }
}