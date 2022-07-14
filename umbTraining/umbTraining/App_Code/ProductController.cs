using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using umbTraining.Models;
namespace umbTraining.App_Code
{
    public class ProductController : RenderMvcController
    {
        public ActionResult Index(ProductContentModel model)
        {
            ProductContentModel productModel = new ProductContentModel(model);

            double productPrice = 0;

            var prodPrice = productModel.GetProperty("productPrice").GetValue().ToString();

            double.TryParse(prodPrice, out productPrice);

            productModel.ProductGstPrice = productPrice + (productPrice * 0.12);

            return CurrentTemplate(productModel);
        }
    }
}