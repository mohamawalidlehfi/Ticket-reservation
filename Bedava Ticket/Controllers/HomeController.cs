using Bedava_Ticket.Data;
using Bedava_Ticket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Diagnostics;

namespace Bedava_Ticket.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

       [HttpPost]
        public IActionResult Index(string Dönüş, string Gidiş, DateOnly GidişZaman, DateOnly DönüşZaman
            ,int Babaklar,int Yetişkinler, int Çocuklar, int Totol)
        {
            BedavaTicketContext db = new BedavaTicketContext();
            var newMüşteri = new Müşteri { Dönüş = Dönüş, Gidiş = Gidiş, GidişZaman = GidişZaman 
                , DönüşZaman = DönüşZaman, Babaklar = Babaklar, Yetişkinler = Yetişkinler , Çocuklar = Çocuklar,Totol = Totol};
            db.Müşteris.Add(newMüşteri);
            db.SaveChanges();
            return RedirectToAction("Cart");
        }
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Privacy(string Name ,string Email ,string Subject , string Massage)
        {
            BedavaTicketContext db = new BedavaTicketContext();
            var newCont = new Contact { Name = Name, Email = Email, Subject = Subject ,Massage = Massage };
            db.Contacts.Add(newCont);
            db.SaveChanges();
            return RedirectToAction("Privacy");
        }
        [HttpGet]
        public IActionResult signpPaga()
        {
            return View();
        }
        [HttpPost]
        public IActionResult signpPaga(string email, string Passoword)
        {
            BedavaTicketContext db = new BedavaTicketContext();
            // يمكنك هنا إضافة رمز لتسجيل المستخدم الجديد إلى قاعدة البيانات
            var newUser = new User { Email = email, Passoword = Passoword };
            db.Users.Add(newUser);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult loginPaga()
        {
            return View();
        }
        [HttpPost]

        public IActionResult loginPaga(string email, string Passoword)
        {
                BedavaTicketContext db = new BedavaTicketContext();
                var user = db.Users.FirstOrDefault(u => u.Email == email && u.Passoword == Passoword);
                if (user != null)
                {
                    // تسجيل الدخول بنجاح، يمكنك تنفيذ الإجراءات اللازمة هنا
                    return RedirectToAction("index", "Home");
                }
                else
                {
                    ViewBag.ErrorMessage = "Invalid email or password";
                    return View();
                }
        }
        

        public IActionResult oteller()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Cart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cart(int KimlikNo,string FirstName ,string LastName, DateOnly Date,string Gender,string Email
                                , int Phone, string billingType, int CardNumber ,int ExpirationDate ,int Cvv )
        {
            BedavaTicketContext db = new BedavaTicketContext();
            var newYolc = new Yolcu { KimlikNo = KimlikNo, FirstName= FirstName, LastName= LastName
                                    , Date= Date, Gender= Gender, Email=Email, Phone=Phone };
            db.Yolcus.Add(newYolc);
            db.SaveChanges();

            var newfat = new Fatura { Type = billingType, KimlikNo = KimlikNo, FirstName = FirstName, LastName = LastName };
            db.Faturas.Add(newfat);
            db.SaveChanges();


            var newodme = new Ödeme { CardNumber = CardNumber, ExpirationDate = ExpirationDate, Cvv = Cvv };
            db.Ödemes.Add(newodme);
            db.SaveChanges();
            return View("index");
        }


        public async Task<IActionResult> BilteList()
        {
            BedavaTicketContext db = new BedavaTicketContext();
            var Müşteri = await db.Müşteris.ToListAsync();
            return View(Müşteri);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
