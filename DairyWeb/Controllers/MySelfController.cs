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
    public class MySelfController : Controller
    {
        private readonly IRepository<MySelf> _mySelf; 
        // GET: MySelf
        public MySelfController(IRepository<MySelf> mySelf)
        {
            this._mySelf = mySelf;
        }
        public ActionResult Index()
        {
            var me = _mySelf.All()
                .Project()
                .To<MySelfInfo>().ToList();
            return View(me);
        }
    }
}