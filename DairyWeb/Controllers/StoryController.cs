namespace DairyWeb.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using DairyWeb.Infrastructure;
    using DairyDataLayer;
    using AutoMapper.QueryableExtensions;
    using DairyModelLayer;
    using DairyWeb.ViewModels;
    public class StoryController : Controller
    {
        private readonly IRepository<Story> _story;
        public StoryController(IRepository<Story> story)
        {
            this._story = story;
        }
        // GET: Story
        public ActionResult Index()
        {
            var allStories = _story.All()
                .Project()
                .To<StoryInfo>();
            return View(allStories);
        }
    }
}