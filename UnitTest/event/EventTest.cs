using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GigaSpaces.Core;
using GigaSpaces.Core.Document;


using xaptutorial.model;

[TestClass]
public class EventTest {
	private SpaceUtility spaceUtility;

	private ISpaceProxy proxy;


	[TestMethod]
	public void notifyTest() {

		// Enable this if you do not want to use Annotations
		// service.registerNotifierListener();

		Payment payment = new Payment();
		payment.Status=ETransactionStatus.CANCELLED;

		proxy.Write(payment);
	}

    [TestMethod]    
	public void pollingTest() {

		// Enable this if you do not want to use Annotations
		// service.registerPollingListener();

		Payment payment = new Payment();
		payment.Status=ETransactionStatus.AUDITED;

		proxy.Write(payment);
	}

    [TestInitialize]
    public void registerProductType()
    {
        if (proxy == null)
        {
            proxy = GigaSpacesFactory.FindSpace("/./xapTutorialSpace");

      //      service = new CRUDService(proxy);
            spaceUtility = new SpaceUtility(proxy);
       //     userUtil = new UserUtil(proxy);
        }


        //	service.registerProductType();
    }

    [TestCleanup]
    public void clear()
    {
        spaceUtility.clear(null);

        //  proxy.Dispose();
    }
}
