using System.Linq;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Events;
using Umbraco.Core.Services;
using Umbraco.Core.Services.Implement;

namespace umbTraining.App_Code
{
    public class SubscribeToContentServiceSavingComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().
                Append<SubscribeToContentServiceSavingComponent>();
        }
    }

    public class SubscribeToContentServiceSavingComponent : IComponent
    {
        // initialize: run once when umbraco starts
        public void Initialize()
        {
            ContentService.Saving += ContentService_Saving;
        }


        //terminate: run once when umbraco stops
        public void Terminate()
        {
            ContentService.Saving -= ContentService_Saving;
        }

        private void ContentService_Saving(IContentService sender, ContentSavingEventArgs e)
        {
            foreach(var content in e.SavedEntities
                .Where(c=> c.ContentType.Alias.InvariantEquals("Page")))
            {
                // do something here
            }
        }
    }
}