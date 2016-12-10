using Kisano.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kisano.Factory
{
    public class Factory
    {

        public static Consumer getConsumerObj()
        {
            Consumer consumer = new Consumer();
            return consumer;

        }


    }
}