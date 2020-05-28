using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication_Assignment3.Models;

namespace MvcApplication_Assignment3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        BookClassDataContext dc = new BookClassDataContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult displayAllBooks()
        {
            return View(dc.books.ToList());
        }

        public ActionResult displayBooks()
        {
            return View(dc.books.Select(b=>b.bookCategory).Distinct().ToList());
        }

        public ActionResult displayBooks1()
        {
            string bCat = Request["bookCategory1"];
            return View(dc.books.Where(a => a.bookCategory == bCat).ToList());
        }
        public ActionResult Category1()
        {
            var bCat = Request["bookCategory1"];
           // areaName.Replace("%20", " ");
            return View(dc.books.Where(a => a.bookCategory == bCat).ToList());
           //  return View(dc.books.ToList());
        }

        public ActionResult addBook()
        {
            return View();
        }

        public ActionResult addBook_DB()
        {
            string bName = Request["bookname"];
            string bAuthor = Request["author"];
            if((bName=="" && bAuthor=="") || (bName!="" && bAuthor=="") ||(bName=="" && bAuthor!=""))
            {
                return RedirectToAction("addBook");
            }
            else
            {
                book b = new book();
                b.bookName = bName;
                b.bookAuthor = bAuthor;
                b.bookEdition = Request["edition"];
                b.bookCategory = Request["bookCategory"];

                dc.books.InsertOnSubmit(b);
                dc.SubmitChanges();
                return RedirectToAction("displayAllBooks");
            }
   
        }

        public ActionResult editBook(int id)
        {
            // It shows the data of specific ID
            return View(dc.books.First(a=>a.Id==id));
        }

        public ActionResult editBook_DB(int id)
        {
            var b = dc.books.First(x => x.Id == id);
            b.bookName = Request["bookname"];
            b.bookAuthor = Request["author"];
            b.bookEdition = Request["edition"];
            b.bookCategory = Request["bookCategory"];
            dc.SubmitChanges();
            return RedirectToAction("displayAllBooks");
        }

        public ActionResult category()
        {         
            return View(Request["cat"]);
        }

        public ActionResult deleteBook_DB(int id)
        {
            var b = dc.books.First(x =>x.Id==id);
            dc.books.DeleteOnSubmit(b);
            dc.SubmitChanges();
            return RedirectToAction("displayAllBooks");
        }

    }
}
