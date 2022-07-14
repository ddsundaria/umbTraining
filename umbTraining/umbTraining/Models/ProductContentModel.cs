using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;
namespace umbTraining.Models
{
    public class ProductContentModel : PublishedContentModel
    {
        public ProductContentModel(IPublishedContent content) : base(content)
        {
        }

        public double ProductGstPrice { get; set; }
    }
}