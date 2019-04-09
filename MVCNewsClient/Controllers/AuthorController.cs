using MVCNewsClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNewsClient.Controllers
{
    public class AuthorController : Controller
    {

        public bool isLogin()
        {
            if (Session["authorid"] == null)
            {
                return false;
            }
            return true;
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string authorName,string password)
        {
            NewsServiceClient ins = new NewsServiceClient();
            Author author = ins.Login(authorName, password);
            if(author.authorId <= 0)
            {
                ViewBag.Message = "Userneme and password incorrect!!";
                return RedirectToAction("Login","Author");
            }
            Session["authorid"] = author.authorId;
            System.Diagnostics.Debug.WriteLine("AUTHOR ID ++++++++" + author.authorId);
            return RedirectToAction("getAllNews","News");

        }

        public ActionResult getAuthor(int id)
        {
            NewsServiceClient ins = new NewsServiceClient();
            Author a = ins.getAuthor(id);
            ViewBag.imgsrc = "data:image;base64," + Convert.ToBase64String(a.imagedata);
            ViewBag.authordata = a;
            return View();
        }

        public ActionResult addAuthor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addAuthor(string authorName, string password, string authorCity, HttpPostedFileBase file)
        {
            NewsServiceClient ins = new NewsServiceClient();
            Author a = new Author();
            a.authorName = authorName;
            a.authorCity = authorCity;
            a.password = password.ToString();
            //System.Diagnostics.Debug.WriteLine("&&&&&&&&&&&77"+authorName+"&&&"+password+"&&&&&"+authorCity);
            if (file != null)
            {
                a.authorImage = file.FileName;
                var fileBytes = new byte[file.ContentLength];
                file.InputStream.Read(fileBytes, 0, fileBytes.Length);
                a.imagedata= fileBytes;

            }
            else
            {
                a.authorImage = null;
                a.imagedata = null;
            }
            int id = ins.addAuthor(a);
            Session["authorid"] = id;
            return RedirectToAction("getAllNews", "News");
        }

        [HttpDelete]
        public ActionResult deleteAuthor(int id)
        {
            NewsServiceClient ins = new NewsServiceClient();
            ins.removeAuthor(id);
            return RedirectToAction("getAllNews", "News");
        }

        public ActionResult updateAuthor()
        {
            NewsServiceClient ins = new NewsServiceClient();
            Author a = ins.getAuthor((int)Session["authorid"]);
            ViewBag.author = a;
            return View();
        }

        [HttpPost]
        public ActionResult updateAuthor(string authorName,string authorCity, HttpPostedFileBase file)
        {
            if (!isLogin())
            {
                return RedirectToAction("Login", "Author");
            }
            NewsServiceClient ins = new NewsServiceClient();
            Author a = new Author();
            a.authorId = (int)Session["authorid"];
            System.Diagnostics.Debug.WriteLine("&&&&&&&&&&&" + (int)Session["authorid"]);
            a.authorName = authorName;
            
            a.authorCity = authorCity;
            
            if (file != null)
            {
                a.authorImage = file.FileName;
                var fileBytes = new byte[file.ContentLength];
                file.InputStream.Read(fileBytes, 0, fileBytes.Length);
                a.imagedata = fileBytes;

            }
            else
            {
                a.authorImage = null;
                a.imagedata = null;
            }
            System.Diagnostics.Debug.WriteLine("&&&&&&&&&&&77" + a.authorId);
            Author author = ins.updateAuthor(a);
            return RedirectToAction("getAuthor", "Author", new { id = author.authorId });
        }

        public ActionResult Logout()
        {
            Session["authorid"] = null;
            return Redirect("Login");
        }
    }
}