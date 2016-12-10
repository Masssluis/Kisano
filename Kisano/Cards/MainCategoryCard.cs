using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Kisano.Cards
{
    public class MainCategoryCard
    {
    
        public static Attachment GetMainCategoryCard()
        {
           
            List<string> mainCategoryList = new List<string>();
            List<CardAction> buttons = new List<CardAction>();

            foreach (var mainCategoryItem in mainCategoryList)
            {
                CardAction button = new CardAction()
                {
                    Title = mainCategoryItem,
                    Type = "imBack"

                };
                buttons.Add(button);
            }


            HeroCard MainCategorycard = new HeroCard()
            {
                Subtitle = "Choose an option below to get started:",
                Buttons = buttons,

            };

            Attachment attachment = MainCategorycard.ToAttachment();
            return attachment;
        }

    }
}