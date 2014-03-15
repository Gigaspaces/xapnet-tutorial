using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using GigaSpaces.Core;
using GigaSpaces.Core.Document;

using xaptutorial.model;

 [TestClass]
public class QueryTest   {
 
	private SpaceUtility spaceUtility;

	private UserUtil userUtil;
	 
	private QueryService queryService;

	private CRUDService service;

	private ISpaceProxy proxy;


      [TestMethod]
	public void findUserById() {
		User user = queryService.findUserById();
		Assert.IsNotNull(user);
	}

      [TestMethod]
	public void findUsersByIds() {
		User[] users = queryService.findUsersByIds();

		Assert.IsNotNull(users);
		Assert.AreEqual(users.Length, 3);
	}

      [TestMethod]
	public void findUserByTemplate() {
		User user = queryService.findUserByTemplate();
		Assert.IsNotNull(user);
	}

      [TestMethod]
	public void findUsersByTemplate() {
		User[] users = queryService.findUsersByTemplate();
		Assert.IsNotNull(users);
		Assert.AreEqual(users.Length, 1);
	}

       [TestMethod]
	public void sqlFindUsersByName() {
		User[] users = queryService.sqlFindUsersByName();
		Assert.IsNotNull(users);
		Assert.AreEqual(users.Length, 1);
	}

       [TestMethod]
	public void sqlFindUsersByNameAndCreditLimit() {
		User[] users = queryService.sqlFindUsersByNameAndCreditLimit();
		Assert.IsNotNull(users);
		Assert.AreEqual(users.Length, 1);
	}

   [TestMethod]
	public void sqlFindUsersByNameAndIds() {
		User[] users = queryService.sqlFindUsersByNameAndIds();
		Assert.IsNotNull(users);
		Assert.AreEqual(users.Length, 1);
	}

       [TestMethod]
	public void sqlParameterFindUsersByName() {
		User[] users = queryService.sqlParameterFindUsersByName();
		Assert.IsNotNull(users);
		Assert.AreEqual(users.Length, 1);
	}

   [TestMethod]
	public void sqlParameterFindUsersByNameAndCreditLimit() {
		User[] users = queryService.sqlParameterFindUsersByNameAndCreditLimit();
		Assert.IsNotNull(users);
		Assert.AreEqual(users.Length, 1);
	}

       [TestMethod]
	public void sqlFindUsersByZipCode() {
		User[] users = queryService.sqlFindUsersByZipCode();
		Assert.IsNotNull(users);
		Assert.AreEqual(users.Length, 2);
	}

       [TestMethod]
	public void sqlFindUsersByPhoneNumber() {
		User[] users = queryService.sqlFindUsersByPhoneNumber();
		Assert.IsNotNull(users);
        Assert.AreEqual(users.Length, 1);
	}

       [TestMethod]
	public void findUsersByNameAndProjection() {
		User[] users = queryService.findUsersByNameAndProjection();
		Assert.IsNotNull(users);
		Assert.AreEqual(users.Length, 1);
	}

       [TestMethod]
	public void findUsersByRating() {
		User[] users = queryService.findUsersByRating();
		Assert.IsNotNull(users);
		Assert.AreEqual(users.Length, 2);
	}

       [TestMethod]
	public void findUsersByGroup() {
		User[] users = queryService.findUsersByGroup();
		Assert.IsNotNull(users);
		Assert.AreEqual(users.Length, 1);
	}

       [TestMethod]
	public void findUsersByComment() {
		User[] users = queryService.findUsersByComment();
		Assert.IsNotNull(users);
		Assert.AreEqual(users.Length, 1);
	}

       [TestMethod]
	public void findUsersBySQLExpression() {
		User[] users = queryService.findUsersBySQLExpression();
		Assert.IsNotNull(users);
		Assert.AreEqual(users.Length, 1);
	}

       [TestMethod]
	public void findUsersByRegularExpression() {
		User[] users = queryService.findUsersByRegularExpression();
		Assert.IsNotNull(users);
		Assert.AreEqual(users.Length, 1);
	}

       [TestMethod]
	public void findUsersByEnum() {
		User[] users = queryService.findUsersByEnum();
		Assert.IsNotNull(users);
		Assert.AreEqual(users.Length, 1);
	}

       [TestMethod]
	public void readProductById() {
		SpaceDocument doc = queryService.readProductById();
		Assert.IsNotNull(doc);

	}

       [TestMethod]
	public void readProductByTemplate() {
		SpaceDocument doc = queryService.readProductByTemplate();
		Assert.IsNotNull(doc);
	}

       [TestMethod]
	public void readProductsBySQL() {
		SpaceDocument[] docs = queryService.readProductsBySQL();
		Assert.IsNotNull(docs);
		Assert.AreEqual(docs.Length, 1);
	}

    [TestInitialize]
	public void registerProductType() {

        if ( proxy == null)
        { 
	    	// Instatiate the embedded space
	    	proxy =   GigaSpacesFactory.FindSpace("/./xapTutorialSpace");;

	    	spaceUtility = new SpaceUtility (proxy);
	    	userUtil = new UserUtil(proxy);
	    	queryService = new QueryService(proxy);
	    	service = new CRUDService(proxy);

	    	// Register the Space Document
	    	
        }

		// Create a user
		userUtil.loadUsers();

        service.registerProductType();
        service.createDocumemt();
	}

    [TestCleanup]
	public void clear() {
		spaceUtility.clear(null);
	}

}
