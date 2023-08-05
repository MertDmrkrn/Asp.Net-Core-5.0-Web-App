using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()//View Component te tanımlanan methotlar genellikle Invoke isminde tanımlanır.
        {
            var values = featureManager.TGetList();
            return View(values);//Invoke methoduna bağlı olarak çalışacak Viewleri Shared klasöründe oluşturduğumuz
                          //Components klasörünün içinde arayıp getireceğiz.
                          //Components klasörüne FeatureList isminde bir klasör ekledik eklediğimiz klasörün ismi class ismi ile aynı olmak zorunda
                          //çünkü arama işlemi için gerekli      
        }
    }
}
