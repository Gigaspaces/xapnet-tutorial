
using System;

using GigaSpaces.Core.Metadata;

[Serializable]
public class Group   {

    [SpaceProperty(StorageType = StorageType.Document)]
	private long? Id;

	private String Name;

	public long? getId() {
		return Id;
	}

	public void setId(long? id) {
		this.Id = id;
	}

	public String getName() {
		return Name;
	}

	public void setName(String name) {
		this.Name = name;
	}

}
