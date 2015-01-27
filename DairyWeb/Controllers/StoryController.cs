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

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(StoryInfo st)
        {
            if (ModelState.IsValid)
            {
                Story storyEntity = new Story
                {
                    StoryText = st.StoryText,
                    StoryDate = st.StoryDate,
                    Title = st.Title,
                    Rate = st.Rate,
                    ImageUrl = st.ImageUrl

                };
                this._story.Add(storyEntity);
                this._story.SaveChanges();
                //Връщам към списъка
                return RedirectToAction("Index");
            }
            else 
            {
                return View(st); 
            }
            return View();
        }
    }
}