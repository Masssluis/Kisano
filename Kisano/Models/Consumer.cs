using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kisano.Models
{
    public class Consumer
    {
        public  string AadharID { get; set; }
        public  string Name { get; set; }
        public  string Age { get; set; }
        public  string Area { get; set; }
        public  string Mandal { get; set; }
        public  string District { get; set; }

        public Consumer GetConsumerDetails(Consumer consumer)
        {
       
            consumer.AadharID =
            consumer.Age =
            consumer.Area =
            consumer.Mandal =
            consumer.District =
            return consumer;

        }
       

    }
}