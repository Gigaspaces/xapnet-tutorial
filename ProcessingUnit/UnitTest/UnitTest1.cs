using System;
using System.Threading;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GigaSpaces.Core;

using common;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        String url = "jini://*/*/eventSpace?groups=XAP-9.7.0-ga-NET-4.0.30319-x64";

        private ISpaceProxy proxy;

        [TestMethod]
	    public void postPayment() {
	 

		// Create a payment
		Payment payment = new Payment();
		payment.CreatedDate=new DateTime();
		payment.MerchantId=1L;
		payment.PaymentAmount=120.70;
		payment.Status=ETransactionStatus.NEW;


        Console.WriteLine(payment.Status);

		// write the payment into the space
		proxy.Write(payment);

        Thread.Sleep(10000);

        SqlQuery<Payment> query = new SqlQuery<Payment>("MerchantId=1");
        payment = proxy.Read<Payment>(query);

        Assert.AreEqual(payment.Status, ETransactionStatus.PROCESSED);

        Console.WriteLine(payment.Status);
	}

       [TestInitialize]
        public void init()
        {
            proxy = GigaSpacesFactory.FindSpace(url);

        }
    }

}
