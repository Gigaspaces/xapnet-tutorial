
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
		u.Id=1L;
		u.Balance=120.90;
		u.CreditLimit=1500.00;
		u.Name="John Dow";
		u.Status=EAccountStatus.ACTIVE;

		Address a = new Address();
		a.City="NYC";
		a.Country=ECountry.USA;
		a.State="NY";
		a.Street="100th East";
		a.ZipCode=12345;
		u.Address=a;
		u.addContact(EContactType.HOME, "770-123-5555");
                                         
		List<int?> ratings = new List<int?>();
		ratings.Add( 1);
		ratings.Add( 4);
		u.Ratings=ratings;

		List<Group> groups = new List<Group>();
		Group g = new Group();
		g.Id =1L;
		g.Name="Group 1";
		groups.Add(g);
		u.Groups=groups;

	//	u.setComment(new String[] { "existing", "customer" });
		proxy.Write(u);

		u = new User();
		u.Id=2L;
		u.Balance=120.90;
		u.CreditLimit=500.00;
		u.Name="Customer 2";
		u.Status=EAccountStatus.INACTIVE;

		a = new Address();
		a.City="NYC";
		a.Country=ECountry.USA;
		a.State="NY";
		a.Street="100th East";
		a.ZipCode=10017;
		u.Address=a;

		ratings = new List<int?>();
		ratings.Add(1);
		ratings.Add( 3);
		u.Ratings=ratings;

		proxy.Write(u);

		u = new User();
		u.Id=3L;
		u.Balance=120.90;
		u.CreditLimit=500.00;
		u.Name="Customer 2";
		u.Status=EAccountStatus.BLOCKED;

		a = new Address();
		a.City="NYC";
		a.Country=ECountry.USA;
		a.State="NY";
		a.Street="100th East";
		a.ZipCode=12345;
		u.Address=a;

		proxy.Write(u);
	}
}
