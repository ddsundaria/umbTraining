using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core;
using Umbraco.Web.Mvc;
using umbTraining.Models;

namespace umbTraining.Controllers
{
    public class ContactFormController : SurfaceController
    {
        public ActionResult Render()
        {
           var contactModel = new ContactModel();
            return PartialView("ContactForm", contactModel);
        }

        public ActionResult Submit(ContactModel model)
        {
            var contentService = Services.ContentService;
            var parentId = new Guid("a1057bfb-caac-47ce-bbff-0d6eeade44c1");
            
            var contact = contentService.Create(model.ContactName, parentId, "contact");
            //var contact = contentService.Create(model.ContactName, 1101, "contact");

            contact.SetValue("contactName", model.ContactName);
            contact.SetValue("contactEmail", model.ContactEmail);
            contact.SetValue("message", model.Message);

            contentService.Save(contact);

            return RedirectToUmbracoPage(1067);
        }
    }
}