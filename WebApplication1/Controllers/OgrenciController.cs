using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OgrenciController : Controller
    {
        //hafizadas sabit kalması icin static  
        static List<Ogrenci> Ogrenciler = new List<Ogrenci>(); 
        public IActionResult Index()
        {
            return View(); 
            //sag tıkla add view diyerek ogrenci klasorunu olusturduk
        }
        public string Parametre(int id)
        {
            return "parametreniz : " + id; //burası id olarak godneriyor baska sey yazınca calısmıyor
        } //http://localhost:5233/ogrenci/parametre diyerek buraya gelebiliriz

        public string Kayit()
        {
            return "Ogrenci->Kayit methodu";
        }

        //php: if( $_POST["OgrAd"]!=null) {}
        //[HttpPost] //post yapıldıysa calıstır diyorum ki bilgi  girmeden kayit metodu calısmasın
        //ki calıstırırsak da hata veriuor vs üzerinden
        //public string Kayit()
        //{
        //    //php: $_POST[OgrAd];
        //    string ad = HttpContext.Request.Form["OgrAd"]; //post ile gonderilen bilgiye erisim saglayabilecegiz
        //    string soyad = HttpContext.Request.Form["OgrSoyad"];
        //    string no = HttpContext.Request.Form["OgrNo"];
        //    //return "Form Bilgileri Kayit:"; 
        //    return "Form Kayit: " + ad + " " + soyad + " " + no;
        //}


        //[HttpPost]
        //public string Kayit(string OgrAd, string OgrSoyad, string OgrNo)
        //{ //formdan aldıgı bilgileri parametre olarak alacak
        //    return "Form Kayit: (Parametreli)" + OgrAd + " " + OgrSoyad + " " + OgrNo;
        //}


        //iki yoldanda olabilir, ancak bos kayit kismi icin parametreli kullkanmamız lzim

        [HttpPost]
        /*public IActionResult Kayit(Ogrenci ogr)
        {
            return View(ogr); //Kayit cshtml ye gidecek, modeli gonderdim
            //return "Form Kayit: (Modelli)" + ogr.OgrAd + " " + ogr.OgrSoyad + " " + ogr.OgrNo;
        }
        */
        public IActionResult Kayit(Ogrenci ogr)
        {
            Ogrenciler.Add(ogr);
            return RedirectToAction("OgrenciListele", "Ogrenci");
        }

        public IActionResult OgrenciListele()
        {
            //return Ogrenciler[0].OgrAd + " " + Ogrenciler[0].OgrSoyad + " " + Ogrenciler[0].OgrNo;
            return View(Ogrenciler);
        }
    }
}
