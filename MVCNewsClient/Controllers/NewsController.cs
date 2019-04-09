using MVCNewsClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNewsClient.Controllers
{
    public class NewsController : Controller
    {
        public bool isLogin()
        {
            if(Session["authorid"] == null)
            {
                return false;
            }
            return true;
        }
        // GET: News
        public ActionResult getAllNews(int authorid=0, string tag=null, string newscity=null)
        {
            NewsServiceClient ins = new NewsServiceClient();
            List<News> list = ins.getAllNews(authorid,tag,newscity).ToList();
            if( list.Count == 0)
            {
                ViewBag.message = "No News available!!";
            }
            ViewBag.List = list;
            return View();
        }

        public ActionResult addNews()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addNews(string title,string description, string tag, HttpPostedFileBase file,string city)
        {
            if (!isLogin())
            {
                return RedirectToAction("Login", "Author");
            }
            NewsServiceClient ins = new NewsServiceClient();
            News n = new News();
            //Author a = ins.getAuthor((int)Session["authorid"]);
            n.title = title;
            n.description = description;
            n.tag = tag;
            n.newsCity = city;
            System.Diagnostics.Debug.WriteLine("ok rokad" + (int)Session["authorid"]);
            Author a = new Author(); 
            a.authorId = (int)Session["authorid"];
            n.author = a;
            if (file != null)
            {
                n.image = file.FileName;
                var fileBytes = new byte[file.ContentLength];
                file.InputStream.Read(fileBytes, 0, fileBytes.Length);
                n.imagedata = fileBytes;

            }
            else
            {
                n.image = null;
                n.imagedata = null;
            }
            int newsid = ins.addNews(n);

            return RedirectToAction("getAllNews","News");
        }

        public ActionResult getNews(int id)
        {
            NewsServiceClient ins = new NewsServiceClient();
            News n = ins.getNews(id);
            ViewBag.news = n;
            return View();
        }

       /* public ActionResult deleteNews()
        {
            return View();
        }*/
        
        public ActionResult deleteNews(int id)
        {
            NewsServiceClient ins = new NewsServiceClient();
            ins.removeNews(id);
            return RedirectToAction("getAllNews", "News");
        }

        public ActionResult updateNews(int id)
        {
            NewsServiceClient ins = new NewsServiceClient();
            News n = ins.getNews(id);
            Session["newsid"] = id;
            ViewBag.news = n;
            return View();
        }
        [HttpPost]
        public ActionResult updateNews(string title, string description, string tag, HttpPostedFileBase file, string city)
        {
            //System.Diagnostics.Debug.WriteLine("11111111");
            if (!isLogin())
            {
                return RedirectToAction("Login", "Author");
            }
            NewsServiceClient ins = new NewsServiceClient();
            News n = new News();

            n.newsId = (int)Session["newsid"];
            n.title = title;

            
            n.description = description;
          
            n.tag = tag;   
            
            n.newsCity = city; 
            Author a = new Author();
            a.authorId = (int)Session["authorid"];
            n.author = a;
            if (file != null)
            {
                n.image = file.FileName;
                var fileBytes = new byte[file.ContentLength];
                file.InputStream.Read(fileBytes, 0, fileBytes.Length);
                n.imagedata = fileBytes;
            }
            else
            {
                n.image = null;
                n.imagedata = null;
            }
            News news= ins.updateNews(n);
            Session["newsid"] = null;
            return RedirectToAction("getNews", "News", new { id = (int)news.newsId });
        }
    }
}