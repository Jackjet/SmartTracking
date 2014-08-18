using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using log4net;
using SmartTracking.Extendsions;
using SmartTracking.Filter;
using SmartTracking.Models;

namespace SmartTracking.Controllers
{
    public class HomeController : Controller
    {
        private const string TrackCode = "_trackCode";
        private const string LogLineTextFormat = "{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}";

        public ActionResult Index([FromUri]HomeIndexRequest model)
        {
            var traceCodeValue = "";

            if (Request.Cookies[TrackCode] == null || string.IsNullOrEmpty(Request.Cookies[TrackCode].Value))
            {
                traceCodeValue = Guid.NewGuid().ToString().ToMd5();
                Response.Cookies.Add(new HttpCookie(TrackCode, traceCodeValue));
            }
            else
            {
                traceCodeValue = Request.Cookies[TrackCode].Value;
            }
            
            var log = LogManager.GetLogger(typeof(object));
            log.Info(string.Format(LogLineTextFormat,
                traceCodeValue,
                model.Domain,
                model.Uri,
                model.Referrer,
                model.ScreenWidth,
                model.ScreenHeight,
                model.ColorDepth,
                model.Lang,
                model.Account,
                model.Event,
                model.Exts));

            return new FilePathResult("ta.jpg", "image/jpeg");
        }
    }
}