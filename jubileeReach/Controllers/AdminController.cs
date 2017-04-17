using jubileeReach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace jubileeReach.Controllers
{
    public class AdminController : Controller
    {
        private Model1 db = new Model1();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alerts()
        {
            return View();
        }

        public ActionResult InventoryAdjustment()
        {
            return View();
        }

        public ActionResult ManageAccounts()
        {
            return View();
        }

        //https://www.codeproject.com/Tips/806845/Dynamic-DropDownList-Binding-in-ASP-NET-MVC-With-D
        public ActionResult UploadItem()
        {
            //Use this web link for dynamic drop down http://www.c-sharpcorner.com/article/creating-simple-cascading-dropdownlist-in-asp-net-core-mvc-with-new-tag-helpers/
            List<DEPARTMENT> departmentlist = new List<DEPARTMENT>();
            departmentlist = (from department in db.DEPARTMENT select department).ToList();
            departmentlist.Insert(0, new DEPARTMENT { DEP_ID = 0, DEPARTMENT_NAME = "Select" });
            ViewBag.ListOfDepartment = departmentlist;
            return View();
        }

        public JsonResult GetCategories(int DEP_ID)
        {
            List<CATEGORY> categoryList = new List<CATEGORY>();
            categoryList = (from category in db.CATEGORY where category.DEP_LINKER == DEP_ID select category).ToList();
            categoryList.Insert(0, new CATEGORY { CAT_ID = 0, CAT_NAME = "Select" });
            return Json(new SelectList(categoryList, "CAT_ID", "CAT_NAME"), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSizes(int CAT_ID)
        {
            List<SIZES> sizeList = new List<SIZES>();

            CATEGORY obj = new CATEGORY();
            obj = (from sizeGroup in db.CATEGORY where sizeGroup.CAT_ID == CAT_ID select sizeGroup).Single();
            sizeList = (from sizes in db.SIZES where sizes.SIZE_GROUP == obj.SIZE_GROUP select sizes).ToList();
            sizeList.Insert(0, new SIZES { SIZE_ID = 0, SIZE_NAME = "Select" });
            return Json(new SelectList(sizeList, "SIZE_ID", "SIZE"));
        }
    }
}