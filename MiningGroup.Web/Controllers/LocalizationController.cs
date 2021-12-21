using Microsoft.AspNetCore.Mvc;
using MiningGroup.Web.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MiningGroup.Web.Controllers
{
    public class LocalizationController : Controller
    {
        public IActionResult GetLanguages()
        {
            var languages = Enum.GetValues(typeof(Language)).Cast<Language>().ToList();
            return View(languages);
        }

        public IActionResult ChangeLanguage(string language)
        {
            var languages = Enum.GetValues(typeof(Language)).Cast<Language>().ToList();
            var isExist = languages.Select(i => i.ToString()).Contains(language);
            if (isExist)
            {
                CultureInfo cultureInfo = new CultureInfo(language);
                CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            }
            return Redirect("/");
        }
    }
}
