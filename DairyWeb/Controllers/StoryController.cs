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
        [HttpPost]
        public ActionResult Index(string txtSearch)
        {
            var allStories = _story.All()
                .Where(x=>x.Title.Contains(txtSearch) || x.StoryText.Contains(txtSearch))
                .Project()
                .To<StoryInfo>();
            return View(allStories);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StoryInfo st)
        {
            string fileName="";
            string path="";
            if (ModelState.IsValid)
            {
                if (st.PostedFile.ContentLength > 0)
                {
                    fileName = System.IO.Path.GetFileName(st.PostedFile.FileName);
                    path = System.IO.Path.Combine(Server.MapPath("~/Content/Pictures/"), fileName);
                    st.PostedFile.SaveAs(path);
                }
                Story storyEntity = new Story
                {
                    StoryText = st.StoryText,
                    StoryDate = st.StoryDate,
                    Title = st.Title,
                    Rate = st.Rate,
                    ImageUrl = fileName
                };
                this._story.Add(storyEntity);
                this._story.SaveChanges();
                //Връщам към списъка
                return RedirectToAction("Index");
            }
                return View(st); 
        }
        public ActionResult Delete(int Id)
        { 
            var storyEntity = _story.All()
                .Where(x => x.StoryID == Id)
                .FirstOrDefault();
            var  path = System.IO.Path.Combine(Server.MapPath("~/Content/Pictures/"), storyEntity.ImageUrl);
            System.IO.File.Delete(path);
            _story.Delete(storyEntity);
            _story.SaveChanges();
            return RedirectToAction("Index");
           // return View();
        }
    }
}