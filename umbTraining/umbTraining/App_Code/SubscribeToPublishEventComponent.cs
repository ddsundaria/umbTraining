using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Services.Implement;

namespace umbTraining.App_Code
{
    public class SubscribeToPublishEventComposer : ComponentComposer<SubscribeToPublishEventComponent>
    {

    }

    public class SubscribeToPublishEventComponent : IComponent
    {
        public void Initialize()
        {
            ContentService.Publishing += ContentService_Publishing;
            
        }

        private void ContentService_Publishing(Umbraco.Core.Services.IContentService sender, Umbraco.Core.Events.ContentPublishingEventArgs e)
        {
           foreach(var node in e.PublishedEntities)
            {
                if(node.ContentType.Alias == "Product")
                {
                    var productName = node.GetValue<string>("productName");
                    if (productName.Equals(productName.ToUpper()))
                    {
                        // stop putting product names in upper case
                        e.Cancel = true;

                        e.Messages.Add(new Umbraco.Core.Events.EventMessage(
                            "Product Name Style guideline invalide", 
                            "Don't put product name in upper case!!!", 
                            Umbraco.Core.Events.EventMessageType.Error));
                    }
                }
            }
        }

        public void Terminate()
        {
            ContentService.Publishing -= ContentService_Publishing;
        }
    }
}