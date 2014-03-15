using System;

using GigaSpaces.Core.Metadata;

[Serializable]
public class Address   {

	private String Street;
	private String City;
	private String State;
    private Nullable<ECountry> Country;

    [SpaceProperty(StorageType = StorageType.Document)]
    private int? ZipCode { set; get; }

	public String getStreet() {
		return Street;
	}

	public void setStreet(String street) {
		this.Street = street;
	}

	public String getCity() {
		return City;
	}

	public void setCity(String city) {
		this.City = city;
	}

	public String getState() {
		return State;
	}

	public void setState(String state) {
		this.State = state;
	}

	public Nullable<ECountry> getCountry() {
		return Country;
	}

	public void setCountry(ECountry country) {
		this.Country = country;
	}

	public int? getZipCode() {
		return ZipCode;
	}

	public void setZipCode(int? zipCode) {
		this.ZipCode = zipCode;
	}

    
}