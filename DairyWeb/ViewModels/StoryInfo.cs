﻿namespace DairyWeb.ViewModels
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
        public string Title { get; set; }
        [Required(ErrorMessage="Моля,задаите дата")]
        public DateTime StoryDate { get; set; }
        [Range(0,6)]
        public int Rate { get; set; }
        [Required(ErrorMessage = "Трябва да се попълни текст към историята")]
        public string StoryText { get; set; }
        public string ImageUrl { get; set; }
    }
}