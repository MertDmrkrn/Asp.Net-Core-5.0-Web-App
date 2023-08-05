using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        //UserMessageManager userMessage = new UserMessageManager(new EfUserMessageDal()); Silinecek
        public IViewComponentResult Invoke()
        {
            //var values = userMessage.GetUserMessageWithUserService();  Silinecek
            return View();
        }
    }
}
