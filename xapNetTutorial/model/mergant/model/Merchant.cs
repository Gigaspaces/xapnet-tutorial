using System;
using GigaSpaces.Core.Metadata; 
using GigaSpaces.Core.Document; 

namespace xaptutorial.model
{
	[SpaceClass]
	public class Merchant {
		[SpaceID(AutoGenerate = false)]
		[SpaceRouting]
		private long? Id;
		private String Name;
		private Double Receipts;
		private Double FeeAmount;
		[SpaceIndex(Type = SpaceIndexType.Basic)]
		private Nullable<ECategoryType> Category;
		private Nullable<EAccountStatus> Status;
		[SpaceDynamicProperties]
		private DocumentProperties ExtraInfo;

		public Merchant() {
		}
			
		public long? getId() {
			return Id;
		}

		public void setId(long? id) {
			this.Id = id;
		}


		public DocumentProperties getExtraInfo() {
			return ExtraInfo;
		}

		public void setExtraInfo(DocumentProperties extraInfo) {
			this.ExtraInfo = extraInfo;
		}

		public void setName(String name) {
			this.Name = name;
		}

		public String getName() {
			return Name;
		}


		public Nullable<ECategoryType> getCategory() {
			return Category;
		}

		public void setCategory(ECategoryType category) {
			this.Category = category;
		}

		public Nullable<EAccountStatus> getStatus() {
			return Status;
		}

		public void setStatus(EAccountStatus status) {
			this.Status = status;
		}

		public void setReceipts(Double receipts) {
			this.Receipts = receipts;
		}

		public Double getReceipts() {
			return Receipts;
		}

		public void setFeeAmount(Double feeAmount) {
			this.FeeAmount = feeAmount;
		}

		public Double getFeeAmount() {
			return FeeAmount;
		}

	}
}