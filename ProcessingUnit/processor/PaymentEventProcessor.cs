using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GigaSpaces.Core.Events;
using GigaSpaces.XAP.Events.Polling;
using GigaSpaces.XAP.Events;

using common;

namespace processor
{
    [PollingEventDriven]
    public class PaymentEventProcessor
    {

        // Define the event we are interested in
        [EventTemplate]
        Payment unprocessedData()
        {
            Payment template = new Payment();
            template.Status=ETransactionStatus.NEW;
            return template;
        }

        [DataEventHandler]
        public Payment eventListener(Payment ev)
        {
            Console.WriteLine("Payment received; processing .....");

            // set the status on the event and write it back into the space
            ev.Status=ETransactionStatus.PROCESSED;
            return ev;
        }
    }
}
