
using System;
using System.Collections;
using System.Collections.Generic;

using GigaSpaces.Core;

using xaptutorial.model;

public class UserUtil {

	private ISpaceProxy proxy;

	public UserUtil(ISpaceProxy proxy)
	{
		this.proxy = proxy;
	}
		
	public void loadUsers() {

		User u = new User();
		u.setId(1L);
		u.setBalance(120.90);
		u.setCreditLimit(1500.00);
		u.setName("John Dow");
		u.setStatus(EAccountStatus.ACTIVE);

		Address a = new Address();
		a.setCity("NYC");
		a.setCountry(ECountry.USA);
		a.setState("NY");
		a.setStreet("100th East");
		a.setZipCode(12345);
		u.setAddress(a);
		u.addContact(EContactType.HOME, "770-123-5555");
                                         
		List<int?> ratings = new List<int?>();
		ratings.Add( 1);
		ratings.Add( 4);
		u.setRatings(ratings);

		List<Group> groups = new List<Group>();
		Group g = new Group();
		g.setId(1L);
		g.setName("Group 1");
		groups.Add(g);
		u.setGroups(groups);

		u.setComment(new String[] { "existing", "customer" });
		proxy.Write(u);

		u = new User();
		u.setId(2L);
		u.setBalance(120.90);
		u.setCreditLimit(500.00);
		u.setName("Customer 2");
		u.setStatus(EAccountStatus.INACTIVE);

		a = new Address();
		a.setCity("NYC");
		a.setCountry(ECountry.USA);
		a.setState("NY");
		a.setStreet("100th East");
		a.setZipCode(10017);
		u.setAddress(a);

		ratings = new List<int?>();
		ratings.Add(1);
		ratings.Add( 3);
		u.setRatings(ratings);

		proxy.Write(u);

		u = new User();
		u.setId(3L);
		u.setBalance(120.90);
		u.setCreditLimit(500.00);
		u.setName("Customer 2");
		u.setStatus(EAccountStatus.BLOCKED);

		a = new Address();
		a.setCity("NYC");
		a.setCountry(ECountry.USA);
		a.setState("NY");
		a.setStreet("100th East");
		a.setZipCode(12345);
		u.setAddress(a);

		proxy.Write(u);

	}
}
