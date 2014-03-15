using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GigaSpaces.Core;
using GigaSpaces.Core.Document;

using xaptutorial.model;

[TestClass]
public class CrudTest {

	private SpaceUtility spaceUtility;
	 
	private UserUtil userUtil;
 
	private ISpaceProxy proxy;

	private CRUDService service;

    [TestMethod]
	public void writeUser() {

		service.writeUser();
		int count = proxy.Count(new User());
		Assert.AreEqual(1, count);
	}

      [TestMethod]
	public void writeUsers() {

		service.writeUsers();
		int count = proxy.Count(new User());
		Assert.AreEqual(2, count);
	}

      [TestMethod]
	public void writeOnlyWithLease() {
		service.writeOnlyWithLease();
		int count = proxy.Count(new User());
		Assert.AreEqual(1, count);
	}

      [TestMethod]
	public void partialUpdate() {

		service.partialUpdate();

        User user = new User();
        user.setId(1L);

		User u = proxy.Read(user);
		Assert.AreEqual(EAccountStatus.BLOCKED, u.getStatus());
	}

      [TestMethod]
	public void ChangeSet() {
		service.ChangeSet();

        User user = new User();
        user.setId(1L);

		User u = proxy.Read<User>(user);
		Assert.AreEqual(EAccountStatus.BLOCKED, u.getStatus());
	}

      [TestMethod]
	public void createDocumemt() {

        service.registerProductType();

		service.createDocumemt();

		SpaceDocument doc = proxy.Read<SpaceDocument>(new SpaceDocument("Product"));
		Assert.IsNotNull(doc);
	}

      [TestMethod]
	public void takeUserById() {

		userUtil.loadUsers();
		User user = service.takeUserById();
		Assert.IsNotNull(user);
		Assert.AreEqual(1, user.getId());
	}

      [TestMethod]
	public void takeUserByTemplate() {

		userUtil.loadUsers();
		User user = service.takeUserByTemplate();

		Assert.AreEqual("John Dow", user.getName());
	}

      [TestMethod]
	public void takeUserBySQL() {

		userUtil.loadUsers();
		User user = service.takeUserBySQL();
		Assert.AreEqual(EAccountStatus.BLOCKED, user.getStatus());
	}

      [TestMethod]
	public void clearUserByTemplate() {

		userUtil.loadUsers();
		service.clearUserByTemplate();

		int count = proxy.Count(new User());
		Assert.AreEqual(0, count);
	}

      [TestMethod]
	public void clearUserBySQL() {

		userUtil.loadUsers();
    	service.clearUserBySQL();

		int count = proxy.Count(new User());
		Assert.AreEqual(2, count);

	}

  [TestMethod]
	public void clearAll() {

		userUtil.loadUsers();
		service.clearAllObjectInSpace();

		int count = proxy.Count(new User());
		Assert.AreEqual(0, count);
	}

	[TestInitialize]
  public    void registerProductType()
  {
      if (proxy == null)
      {
          proxy = GigaSpacesFactory.FindSpace("/./xapTutorialSpace");

          service = new CRUDService(proxy);
          spaceUtility = new SpaceUtility(proxy);
          userUtil = new UserUtil(proxy);
      }
	}

	[TestCleanup]
	public void clear() {
		spaceUtility.clear(null);

      //  proxy.Dispose();
	}

}
