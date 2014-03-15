using System;

using GigaSpaces.Core.Events;
using GigaSpaces.XAP.Events.Polling;  
using GigaSpaces.XAP.Events;

using xaptutorial.model;

[PollingEventDriven]
[TransactionalEvent]
public class AuditListener {

	[EventTemplate]
	Payment unprocessedData() {
		Payment template = new Payment();
		template.setStatus(ETransactionStatus.AUDITED);
		return template;
	}

	[DataEventHandler]
	public Payment eventListener(Payment e) {
		// process Payment
		Console.WriteLine("Polling Received a payment:");		
		return null;
	}
}