using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kisano.Models
{
    public class MainCategory
    {
        public List<string> CategoryItems { get; set; }


        public static List<string> GetMainCategoryList()
        {
            MainCategory mainCategory = new MainCategory();
            mainCategory.CategoryItems.Add("Request Soil Test");
            mainCategory.CategoryItems.Add("Agro Store");
            mainCategory.CategoryItems.Add("Quick Suggestions");
            mainCategory.CategoryItems.Add("General Query");
            mainCategory.CategoryItems.Add("Logout");

            return  mainCategory.CategoryItems;
        }

    }
}