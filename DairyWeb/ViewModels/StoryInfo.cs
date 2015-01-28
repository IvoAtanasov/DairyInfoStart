namespace DairyWeb.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;
    using DairyWeb.Infrastructure;
    using DairyModelLayer;
    public class StoryInfo :IMapFrom<Story>
    {
        [Key]
        public int StoryID { get; set; }
        [Required(ErrorMessage="Моля, задайте заглавие")]
        [Display(Name="Заглавие")]
        public string Title { get; set; }
        [Required(ErrorMessage="Моля,задаите дата")]
        [Display(Name="Дата")]
        public DateTime StoryDate { get; set; }
        [Range(0,6)]
        [Display(Name="Рейтинг на историята")]
        public int Rate { get; set; }
        [Required(ErrorMessage = "Трябва да се попълни текст към историята")]
        [Display(Name="Text")]
        public string StoryText { get; set; }
        [Display(Name = "Файл за снимка на събитието")]
        public HttpPostedFileBase PostedFile { get; set; }
        public string ImageUrl { get; set; }
    }
}