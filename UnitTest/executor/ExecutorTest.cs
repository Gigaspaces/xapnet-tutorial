using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GigaSpaces.Core;


 [TestClass]
public class ExecutorTest   {

 
	private SpaceUtility spaceUtility;
	 
	private ISpaceProxy proxy;

 
	private ExecutorService service;

       [TestMethod]
	public void executeTask()  {
		service.executeTask();

	}

	//	[Test]
	//public void executeTaskWithRouting() {
	//	service.executeTaskWithRouting();

	//}

       [TestMethod]
	public void executeTaskWithRoutingAnnoation()   {
		service.executeTaskWithRoutingPOJO();

	}

	//	[Test]
	//public void executeTaskRoutingAnnoation()   {
	//	service.executeTaskRoutingAnnoation();

	//}

       [TestMethod]
	public void executeDistgributedTask()   {
		service.executeDistributedTask();

	}



       [TestMethod]
	public void asyncListenerTest() {
		try {
			service.executeAsyncTask();
			
			System.Threading.Thread.Sleep(10000); 
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.ToString();
		}
	}
}
