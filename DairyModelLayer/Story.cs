namespace DairyModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    public class Story
    {
        [Key]
        public int StoryID { get; set; }
        public string Title { get; set; }
        public DateTime StoryDate { get; set; }
        public int Rate { get; set; }
        public string StoryText { get; set; }
        public string ImageUrl { get; set; }

    }

}