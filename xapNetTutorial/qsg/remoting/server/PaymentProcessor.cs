using System;

using GigaSpaces.Core;
using GigaSpaces.XAP.Remoting;

using xaptutorial.model;

[SpaceRemotingService]
public class PaymentProcessor : IPaymentProcessor {

	public Payment processPayment(Payment payment) {
		Console.WriteLine("Processing payment ");
		return payment;
	}
}
