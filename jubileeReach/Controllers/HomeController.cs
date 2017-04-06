using jubileeReach.Views;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jubileeReach.Controllers
{
    public class HomeController : Controller
    {
        // Declare the table entites within the Data folder, file named ApplicationDbContext
        //private readonly ApplicationDbContext _context;
        private Model1 db = new Model1();

        //public HomeController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

       // public ActionResult MensList(string filterColor, bool Blue, bool Green, bool Gray, string sortOrder)
        public ActionResult MensList()
        {

            //ViewData["SalePriceSortParm"] = String.IsNullOrEmpty(sortOrder) ? "price_desc" : "";

            //var mensList = from mens in _context.PRODUCT
            //            .Where(m => m.DEP_ID.Equals(1) && m.IS_AVAILABLE == true)
            //                join category in _context.CATEGORY on mens.CAT_ID equals category.CAT_ID
            //                join size in _context.SIZES on mens.SIZE_ID equals size.SIZE_ID
            //                join image in _context.IMAGES on mens.IMG_ID equals image.IMAGE_TABLE_ID
            //                join color in _context.COLORS on mens.COLOR_ID equals color.COLOR_ID
            //                select new PRODUCT_CATEGORY_SIZES_IMAGES
            //                {
            //                    PRODUCTID = mens.PRODUCTID,
            //                    IMG1 = image.IMG1,
            //                    BRAND = mens.BRAND,
            //                    CAT_NAME = category.CAT_NAME,
            //                    SIZE = size.SIZE,
            //                    SALE_PRICE = mens.SALE_PRICE,
            //                    COLOR_NAME = color.COLOR_NAME
            //                };

            //if (!String.IsNullOrWhiteSpace(filterColor))
            //{
            //    mensList = mensList.Where(s => s.COLOR_NAME.Contains(filterColor));
            //}

            //if (Blue)
            //{
            //    mensList = mensList.Where(s => s.COLOR_NAME.Contains("Blue"));
            //}

            //if (Green)
            //{
            //    mensList = mensList.Where(s => s.COLOR_NAME.Contains("Green"));
            //}

            //if (Gray)
            //{
            //    mensList = mensList.Where(s => s.COLOR_NAME.Contains("Gray"));
            //}

            //switch (sortOrder)
            //{
            //    case "price_desc":
            //        mensList = mensList.OrderByDescending(s => s.SALE_PRICE);
            //        break;
            //}

            //return View(mensList);
            var list = db.PRODUCTs.ToList();
            return View(list);
        }

        // GET: PRODUCTs/Details/5
        public ActionResult productDetail(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //https://docs.microsoft.com/en-us/ef/core/modeling/relationships
            //https://docs.microsoft.com/en-us/ef/core/querying/related-data
            //https://msdn.microsoft.com/en-us/library/jj574232(v=vs.113).aspx
            //https://github.com/aspnet/EntityFramework/issues/6091
            //https://msdn.microsoft.com/en-us/library/bb311040.aspx
            //http://stackoverflow.com/questions/22368726/how-to-combine-two-models-into-a-single-model-and-pass-it-to-view-using-asp-net
            //var productDetail = _context.PRODUCT.Where(m => m.PRODUCTID == id)

            //var productDetail = from singleProduct in _context.PRODUCT
            //                    .Where(m => m.PRODUCTID == id)
            //                    join images in _context.IMAGES on singleProduct.IMG_ID equals images.IMAGE_TABLE_ID
            //                    join size in _context.SIZES on singleProduct.SIZE_ID equals size.SIZE_ID
            //                    select new Product_Images_Sizes
            //                    {
            //                        BRAND = singleProduct.BRAND,
            //                        SIZE_ID = singleProduct.SIZE_ID,
            //                        SALE_PRICE = singleProduct.SALE_PRICE,
            //                        ITEM_DESCRIPTION = singleProduct.ITEM_DESCRIPTION,
            //                        IMG1 = images.IMG1,
            //                        IMG2 = images.IMG2,
            //                        IMG3 = images.IMG3,
            //                        IMG4 = images.IMG4,
            //                        SIZE = size.SIZE,
            //                        PRODUCTID = singleProduct.PRODUCTID
            //                    };

            ////var test = _context.PRODUCT.Where(m => m.PRODUCTID == id)
            ////    .Include(Product => Product.IMAGES)
            ////    .ToList();


            //if (productDetail == null)
            //{
            //    return NotFound();
            //}

            //return View(productDetail);

            return View();
        }

        public ActionResult WomensList()
        {
            //var womens = from s in _context.PRODUCT select s;
            //var womens = _context.PRODUCT.Where(b => b.DEP_ID.Equals(2));
            // implement store procedure for getAllItems
            //var womensList = from womens in _context.PRODUCT
            //            .Where(m => m.DEP_ID.Equals(2) && m.IS_AVAILABLE == true)
            //                    join category in _context.CATEGORY on womens.CAT_ID equals category.CAT_ID
            //                    join size in _context.SIZES on womens.SIZE_ID equals size.SIZE_ID
            //                    join image in _context.IMAGES on womens.IMG_ID equals image.IMAGE_TABLE_ID
            //                    select new PRODUCT_CATEGORY_SIZES_IMAGES
            //                    {
            //                        PRODUCTID = womens.PRODUCTID,
            //                        IMG1 = image.IMG1,
            //                        BRAND = womens.BRAND,
            //                        CAT_NAME = category.CAT_NAME,
            //                        SIZE = size.SIZE,
            //                        SALE_PRICE = womens.SALE_PRICE
            //                    };

            //return View(womensList);
            return View();
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult ItemList()
        {
            return View();
        }
        // Dan added this 
        public ActionResult searchList(string searchString)
        {
            //var products = from s in _context.PRODUCT select s;

            //if (!String.IsNullOrWhiteSpace(searchString))
            //{
            //    products = products.Where(s => s.BRAND.Contains(searchString));
            //}
            //return View(products);
            return View();
        }

        public ActionResult Confirmation(PURCHASEDEMO test)
        {
            //var info = from product in _context.PRODUCT
            //            .Where(m => m.PRODUCTID.Equals(test.PRODUCTID))
            //            select new PURCHASEINFO
            //            {
            //                ORDER_ID = test.ORDER_ID,
            //                FIRST_NAME = test.FIRST_NAME,
            //                PICK_UP_TIME = test.PICK_UP_TIME,
            //                DATE_PURCHASED = test.DATE_PURCHASED,
            //                LAST_NAME = test.LAST_NAME,
            //                EMAIL = test.EMAIL,
            //                PHONENUMBER = test.PHONENUMBER,
            //                SALE_PRICE = product.SALE_PRICE,
            //                BRAND = product.BRAND,
            //                ITEM_DESCRIPTION = product.ITEM_DESCRIPTION
            //            };

            //return View(info);
            return View();
        }

        public ActionResult Checkout(int id)
        {
            //var product = _context.PRODUCT.SingleOrDefault(m => m.PRODUCTID == id);
            //return View(product);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Checkout(string firstName, string lastName, string email, string phoneNumber, int? id)
        {

            //if (ModelState.IsValid)
            //{
            //    DbCommand cmd = _context.Database.GetDbConnection().CreateCommand();

            //    cmd.CommandText = "dbo.markItemNotAvailable";
            //    cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //    cmd.Parameters.Add(new SqlParameter("@productID", System.Data.SqlDbType.Int) { Value = (int)id });

            //    if (cmd.Connection.State != ConnectionState.Open)
            //    {
            //        cmd.Connection.Open();
            //    }

            //    cmd.ExecuteNonQuery();

            //    var newPurchaseOrder = new PURCHASEDEMO();
            //    newPurchaseOrder.FIRST_NAME = firstName;
            //    newPurchaseOrder.LAST_NAME = lastName;
            //    newPurchaseOrder.EMAIL = email;
            //    newPurchaseOrder.PHONENUMBER = phoneNumber;
            //    newPurchaseOrder.PRODUCTID = (int)id;

            //    _context.PURCHASEDEMO.Add(newPurchaseOrder);
            //    _context.SaveChanges();


            //    //http://www.mimekit.net/docs/html/M_MailKit_Net_Smtp_SmtpClient_Connect_1.htm
            //    var message = new MimeMessage();
            //    message.From.Add(new MailboxAddress("Dan", "dandoan15@gmail.com"));
            //    message.To.Add(new MailboxAddress(firstName, email));
            //    message.Subject = "Purchase Order: " + id + "Jubilee REACH";
            //    message.Body = new TextPart("plain")
            //    {
            //        Text = "Hi " + firstName + " " + lastName + ", \n Thank you for your purchase!"
            //    };

            //    using (var client = new SmtpClient())
            //    {
            //        client.ServerCertificateValidationCallback = (s, c, h, e) => true;
            //        client.Connect("smtp.gmail.com", 587, false);
            //        client.AuthenticationMechanisms.Remove("XOAUTH2");
            //        client.Authenticate("dandoan15", "renton2011");
            //        client.Send(message);
            //        client.Disconnect(true);
            //    };



            //    ////Set the html version of the message text
            //    //builder.HtmlBody = string.Format(@"<p>Hey Alice,<br>
            //    //<p>What are you up to this weekend? Monica is throwing one of her parties on
            //    //Saturday and I was hoping you could make it.<br>
            //    //<p>Will you be my +1?<br>
            //    //<p>-- Joey<br>");

            //    //message.Body = builder.ToMessageBody();

            //    //using (var client = new SmtpClient())
            //    //{
            //    //    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
            //    //    client.Connect("smtp.gmail.com", 587, false);
            //    //    client.AuthenticationMechanisms.Remove("XOAUTH2");
            //    //    client.Authenticate("dandoan15", "renton2011");
            //    //    client.Send(message);
            //    //    client.Disconnect(true);
            //    //};

            //    return RedirectToAction("Confirmation", newPurchaseOrder);

            //}
            return View();
        }
    }
}
