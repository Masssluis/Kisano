using Kisano.Cards;
using Kisano.Models;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Kisano.Dialog
{
    [LuisModel("f905f8a4-fd07-476f-a928-9457aa7a9695", "e31aa77294fc41f4854be4565f609c3c")]
    [Serializable]
    public class KisanoLuisDailog:LuisDialog<object>
    {
        public static Consumer ConsumerDetails { get; set; }
        public const string Entity_Area = "Area";
        public const string Entity_Mandal = "Mandal";
        public const string Entity_District = "District";

        [LuisIntent("Greeting")]
        public async Task Greeting(IDialogContext context, LuisResult result)
        { 
            var message = context.MakeMessage();
            SQLData.MakeConnection(); //make sql connection.
            await context.PostAsync("Hi, I am Kisano a agriculture oriented bot.  \nType \"Help\" to know more.");
            Consumer consumer = Factory.Factory.getConsumerObj();
            ConsumerDetails=consumer.GetConsumerDetails(consumer);

            PromptDialog.Confirm(context,PostAreaConfirmationAsync, $"Hello {ConsumerDetails.Name}, are you in {ConsumerDetails.Area}", "Kindly, confirm your location", 3);
            
            
        }

        public async Task PostAreaConfirmationAsync(IDialogContext context, IAwaitable<bool> result)
        {
            var message = context.MakeMessage();
            var confirm = await result;
            if (confirm)
            {
                var attachment = MainCategoryCard.GetMainCategoryCard();
                message.Attachments.Add(attachment);
                context.Wait(MessageReceived);
            }
            else
            {
                await context.PostAsync("Please provide your Area, Mandal and District. \n(for example alwal, Malkajgiri, Hyderabad)");         
            }

        }

        [LuisIntent("NewAddress")]
        public async Task NewAddress(IDialogContext context, LuisResult result)
        {
            
            EntityRecommendation title;
            if (result.TryFindEntity(Entity_Area, out title))
            {
                ConsumerDetails.Area = title.Entity;
            }
            if (result.TryFindEntity(Entity_Mandal, out title))
            {
               ConsumerDetails.Mandal = title.Entity;
            }
            if (result.TryFindEntity(Entity_District, out title))
            {
                ConsumerDetails.District = title.Entity;
            }
               // send this to sql              

        }

        [LuisIntent("NewSoilRequest")]
        public async Task NewSoilRequest(IDialogContext context, LuisResult result)
        {
            await Message = "";


        }

        [LuisIntent("TestResults")]
        public async Task SoilTestResult(IDialogContext context, LuisResult result)
        {
            Entity


        }

        [LuisIntent("Help")]
        public async Task Help(IDialogContext context, LuisResult result)
        {




        }

        [LuisIntent("Logout")]
        public async Task Logout(IDialogContext contexet, LuisResult result)
        {



        }




    }
}