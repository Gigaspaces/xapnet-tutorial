using System;
using GigaSpaces.Core.Metadata; 

[SpaceClass]
public class AuditRecord1 {

	[SpaceID]
	[SpaceRouting]
	private long? Id;

	private long? TimeStamp { set; get; }
	private String Application{ set; get; }
	private String AuditContent{ set; get; }
	private String UserName{ set; get; }


	public long? getId() {
		return Id;
	}

	public void setId(long? id) {
		this.Id = id;
	}

	public long? getTimeStamp() {
		return TimeStamp;
	}

	public void setTimeStamp(long? timeStamp) {
		this.TimeStamp = timeStamp;
	}

	public String getApplication() {
		return Application;
	}

	public void setApplication(String application) {
		this.Application = application;
	}

	public String getAuditContent() {
		return AuditContent;
	}

	public void setAuditContent(String auditContent) {
		this.AuditContent = auditContent;
	}

	public String getUserName() {
		return UserName;
	}

	public void setUserName(String userName) {
		this.UserName = userName;
	}

}
