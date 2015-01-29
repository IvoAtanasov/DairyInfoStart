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
        [Display(Name="Име")]
        public string Name { get; set; }
        [Display(Name="Рожденна дата")]
        [DataType(DataType.DateTime)]
        public DateTime Born { get; set; }
        [Display(Name="Информация")]
        public string Info { get; set; }
        [Display(Name="Снимка")]
        public string ImageUrl { get; set; }
    }
}