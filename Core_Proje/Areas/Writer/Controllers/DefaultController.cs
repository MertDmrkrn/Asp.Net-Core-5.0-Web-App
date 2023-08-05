using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]//Hangi areayı kullandığımızı belirtmemiz gerekiyor. Syntax yapısı bu şekilde
    [Authorize]
    public class DefaultController : Controller
    {
        //BİLGİ: layout seçimi yaparken illa ki area klasörü içerisindeki bir layoutu kullanmak zorunda değiliz.

        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        
        public IActionResult Index()
        {
            var values = announcementManager.TGetList();
            return View(values);
        }

        [HttpGet]
        //Index sayfası görünüm katmanına "detaylar" isimli buton atadık ve bu buton a erişmek için bir "AnnouncementDetails"
        //adlı controller tanımladık.
        //Daha sonra AnnouncementDetails isimli controller'a sağ tıklayıp WriterLayout isimli Layoutu kullanan bir Razor View ekleyerek
        //Detaylar görünümünü ayarladık.
        public IActionResult AnnouncementDetails(int id)
        {
            Announcement announcement= announcementManager.TGetByID(id);
            return View(announcement);
        }
    }
}
