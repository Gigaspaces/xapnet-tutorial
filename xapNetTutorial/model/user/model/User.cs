using System;
using System.Collections.Generic;

using GigaSpaces.Core.Metadata;  

namespace xaptutorial.model
{
	[CompoundSpaceIndex(Paths = new[] {"Name", "CreditLimit"})]
	[SpaceClass]
	public class User {
	
		[SpaceID(AutoGenerate = false)]
		[SpaceRouting]
		public long? Id { set; get; }
		[SpaceIndex(Type = SpaceIndexType.Basic)]
		private String Name{ set; get; }
		private double? Balance{ set; get; }
		[SpaceIndex(Type = SpaceIndexType.Extended)]
		private double? CreditLimit{ set; get; }

        [SpaceProperty(StorageType = StorageType.Document)]
		private Nullable<EAccountStatus> Status{ set; get; }

        [SpaceProperty(StorageType = StorageType.Document)]
        [SpaceIndex(Path = "ZipCode", Type = SpaceIndexType.Basic)]
		private Address Address{ set; get; }

		[SpaceIndex(Path = "[*]")]
		private String[] Comment{ set; get; }

        [SpaceProperty(StorageType = StorageType.Document)]
		[SpaceIndex(Path = "HOME")]
		public Dictionary<String, String> Contacts{ set; get; }

        [SpaceProperty(StorageType = StorageType.Document)]
		[SpaceIndex(Path = "[*].Id")]
		private List<Group> Groups{ set; get; }
        
        [SpaceProperty(StorageType = StorageType.Document)]
		[SpaceIndex(Path = "[*]")]
		private List<int?> Ratings{ set; get; }

		public User() {
		}
			
//		public long? getId() {
//			return Id;
//		}

//		public void setId(long? id) {
//			this.Id = id;
//		}

		public void setName(String name) {
			this.Name = name;
		}
			
		public String getName() {
			return Name;
		}
			
		public double? getCreditLimit() {
			return CreditLimit;
		}

		public void setBalance(double? balance) {
			this.Balance = balance;
		}

		public double? getBalance() {
			return Balance;
		}

		public void setCreditLimit(double? creditLimit) {
			this.CreditLimit = creditLimit;
		}

		public void setStatus(EAccountStatus status) {
			this.Status = status;
		}

		public Nullable<EAccountStatus> getStatus() {
			return Status;
		}


		public Address getAddress() {
			return Address;
		}

		public void setAddress(Address address) {
			this.Address = address;
		}


		public Dictionary<String, String> getContacts() {
			return Contacts;
		}

		public void setContacts(Dictionary<String, String> contacts) {
			this.Contacts = contacts;
		}

		public void addContact(EContactType type, String contact) {
			if (Contacts == null) {
				Contacts = new Dictionary<String, String>();
			}
			Contacts.Add(type.ToString(), contact);
		}
			
		public List<Group> getGroups() {
			return Groups;
		}

		public void setGroups(List<Group> groups) {
			this.Groups = groups;
		}
			
		public List<int?> getRatings() {
			return Ratings;
		}

		public void setRatings(List<int?> ratings) {
			this.Ratings = ratings;
		}
			
		public String[] getComment() {
			return Comment;
		}

		public void setComment(String[] comment) {
			this.Comment = comment;
		}
	}
}